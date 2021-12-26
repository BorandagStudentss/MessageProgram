using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinamaProje
{
    public partial class ServerForm : MetroFramework.Forms.MetroForm
    {
        public ServerForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private string ip = "192.168.1.104";
        public int sifre = 1234;
        public static string alinanMesaj;
        public static bool spnMidir;
        public static bool shaMidir;
        public static byte[] realData;
        public static string fileName;
        public static int fileNameLenght;
        string receivedPath = "yok";
        Socket socket;
        NetworkStream stream;

        TcpListener listener;

        private void ServerForm_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(8081);
            listener.Start();

            socket = listener.AcceptSocket();
            stream = new NetworkStream(socket);
            Thread dinle = new Thread(SoketDinle);
            dinle.Start();
        }
        BinaryFormatter bf = new BinaryFormatter();
        public byte[] buffer;
        void SoketDinle()
        {
            while (socket.Connected)
            {

                Mesaj mesaj = (Mesaj)bf.Deserialize(stream);
                alinanMesaj = mesaj.ToString();
                shaMidir = mesaj.shaBool();
                spnMidir = mesaj.spnBool();
                realData = mesaj.DataSend();

                if (realData == null) // dosya okuma 
                {

                }
                else
                {
                    mtrLblFileInformation.Text = "İndirilecek dosyanız var. Dosyayı indirmek için şifrenizi giriniz.";
                }


                if (shaMidir == true & spnMidir == true)
                {
                    mtrTxtPlain.Text = Spn(hash(alinanMesaj));
                }
                else if (shaMidir == true & spnMidir == false)
                {
                    mtrTxtPlain.Text = hash(alinanMesaj);
                }
                else if (shaMidir == false & spnMidir == true)
                {
                    mtrTxtPlain.Text = Spn(alinanMesaj);
                }
                else
                {

                }

                mtrChbSpn.Checked = false;
                mtrChbSHA256.Checked = false;

            }
        }
        static byte[] Compress(byte[] data)
        {
            using (var compressedStream = new MemoryStream())
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Compress))
            {
                zipStream.Write(data, 0, data.Length);
                zipStream.Close();
                return compressedStream.ToArray();
            }
        }

        static byte[] Decompress(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }
        private byte[] key = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        private byte[] iv = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        private byte[] input = new byte[16] { 0x1E, 0xA0, 0x35, 0x3A, 0x7D, 0x29, 0x47, 0xD8, 0xBB, 0xC6, 0xAD, 0x6F, 0xB5, 0x2F, 0xCA, 0x84 };
        public byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(data, encryptor);
                }
            }
        }

        public byte[] Decrypt(byte[] data, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.Zeros;

                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(data, decryptor);
                }
            }
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }

        string hash(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256hashstring.ComputeHash(bytes);
            string hashstring = string.Empty;
            foreach (byte x in hash)
            {
                hashstring += String.Format("{0:x2}", x);
            }
            return hashstring;
        }


        public char[] ShuffleSpn(char[] XORBinaryArr)
        {
            char[] XORBinaryArr2 = new char[16];


            int a = 0;
            int b = 4;
            int c = 8;
            int d = 12;
            for (int i = 0; i < XORBinaryArr.Length; i += 4)
            {
                XORBinaryArr2[a] = XORBinaryArr[i];
                XORBinaryArr2[b] = XORBinaryArr[i + 1];
                XORBinaryArr2[c] = XORBinaryArr[i + 2];
                XORBinaryArr2[d] = XORBinaryArr[i + 3];
                a++;
                b++;
                c++;
                d++;
            }
            return XORBinaryArr2;
        }

        public char[] ShuffleSpnCoz(char[] XORBinaryArr)
        {
            char[] XORBinaryArr2 = new char[16];


            int a = 0;
            int b = 4;
            int c = 8;
            int d = 12;
            for (int i = 0; i < XORBinaryArr.Length; i += 4)
            {
                XORBinaryArr2[i] = XORBinaryArr[a];
                XORBinaryArr2[i + 1] = XORBinaryArr[b];
                XORBinaryArr2[i + 2] = XORBinaryArr[c];
                XORBinaryArr2[i + 3] = XORBinaryArr[d];
                a++;
                b++;
                c++;
                d++;
            }


            return XORBinaryArr2;
        }


        public char[] CrossSpn(char[] textBinaryArr, char[] keyBinaryArr)
        {
            char[] XORBinaryArr = new char[16];

            for (int i = 0; i < textBinaryArr.Length; i++)
            {
                if (textBinaryArr[i] == keyBinaryArr[i])
                {
                    XORBinaryArr[i] = '0';
                }
                else
                {
                    XORBinaryArr[i] = '1';
                }
            }

            return XORBinaryArr;
        }


        public string cevap;
        char[] partText1 = new char[8];
        char[] partText2 = new char[8];
        string Spn(string mesaj)
        {
            cevap = "";
            byte[] asciiBytes = Encoding.ASCII.GetBytes(mesaj);
            byte[] asciiBytesKey = Encoding.ASCII.GetBytes("CDEFGHIJ");
            string[] binaryFormat = asciiBytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            string[] keyBinaryFormat = asciiBytesKey.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();

            string keyBinary = (Convert.ToString(keyBinaryFormat[0]) + Convert.ToString(keyBinaryFormat[1]));
            string key2Binary = (Convert.ToString(keyBinaryFormat[2]) + Convert.ToString(keyBinaryFormat[3]));
            string key3Binary = (Convert.ToString(keyBinaryFormat[4]) + Convert.ToString(keyBinaryFormat[5]));
            string key4Binary = (Convert.ToString(keyBinaryFormat[6]) + Convert.ToString(keyBinaryFormat[7]));
            char[] keyBinaryArr = keyBinary.ToCharArray();
            char[] key2BinaryArr = key2Binary.ToCharArray();
            char[] key3BinaryArr = key3Binary.ToCharArray();
            char[] key4BinaryArr = key4Binary.ToCharArray();

            for (int q = 0; q < binaryFormat.Length - 1; q += 2)
            {
                string textBinary = (Convert.ToString(binaryFormat[q]) + Convert.ToString(binaryFormat[q + 1]));
                char[] textBinaryArr = textBinary.ToCharArray();
                char[] XORBinaryArr = new char[16];

                XORBinaryArr = CrossSpn(CrossSpn(ShuffleSpn(CrossSpn(ShuffleSpn(CrossSpn(textBinaryArr, keyBinaryArr)), key2BinaryArr)), key3BinaryArr), key4BinaryArr);

                for (int i = 0; i < XORBinaryArr.Length; i++)
                {
                    if (i < 8)
                    {
                        partText1[i] = XORBinaryArr[i];
                    }
                    else if (i > 7)
                    {
                        partText2[i - 8] = XORBinaryArr[i];
                    }
                }

                string strPart1 = new string(partText1);
                string strPart2 = new string(partText2);

                cevap = cevap + strPart1 + strPart2;

            }
            if (binaryFormat.Length % 2 == 1)
            {
                string textBinary = (Convert.ToString(binaryFormat[binaryFormat.Length - 1]) + "00000000");
                char[] textBinaryArr = textBinary.ToCharArray();
                char[] XORBinaryArr = new char[16];

                XORBinaryArr = CrossSpn(CrossSpn(ShuffleSpn(CrossSpn(ShuffleSpn(CrossSpn(textBinaryArr, keyBinaryArr)), key2BinaryArr)), key3BinaryArr), key4BinaryArr);


                for (int i = 0; i < XORBinaryArr.Length; i++)
                {
                    if (i < 8)
                    {
                        partText1[i] = XORBinaryArr[i];
                    }
                    else if (i > 7)
                    {
                        partText2[i - 8] = XORBinaryArr[i];
                    }
                }
                string strPart1 = new string(partText1);
                string strPart2 = new string(partText2);

                cevap = cevap + strPart1 + strPart2;

            }

            return cevap;

        }

        string cozulmusCevap;

        void spnCoz(string cozulecekMesaj)
        {
            cozulmusCevap = "";
            char[] part1 = new char[8];
            char[] part2 = new char[8];
            byte[] asciiBytesKey = Encoding.ASCII.GetBytes("CDEFGHIJ");
            string[] keyBinaryFormat = asciiBytesKey.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            string keyBinary = (Convert.ToString(keyBinaryFormat[0]) + Convert.ToString(keyBinaryFormat[1]));
            string key2Binary = (Convert.ToString(keyBinaryFormat[2]) + Convert.ToString(keyBinaryFormat[3]));
            string key3Binary = (Convert.ToString(keyBinaryFormat[4]) + Convert.ToString(keyBinaryFormat[5]));
            string key4Binary = (Convert.ToString(keyBinaryFormat[6]) + Convert.ToString(keyBinaryFormat[7]));
            char[] keyBinaryArr = keyBinary.ToCharArray();
            char[] key2BinaryArr = key2Binary.ToCharArray();
            char[] key3BinaryArr = key3Binary.ToCharArray();
            char[] key4BinaryArr = key4Binary.ToCharArray();


            for (int q = 0; q < cozulecekMesaj.Length; q += 16)
            {
                string textBinary = "";
                textBinary = cozulecekMesaj.Substring(q, 16);
                char[] textBinaryArr = textBinary.ToCharArray();
                char[] XORBinaryArr = new char[16];

                XORBinaryArr = CrossSpn(ShuffleSpnCoz(CrossSpn(ShuffleSpnCoz(CrossSpn(CrossSpn(textBinaryArr, key4BinaryArr), key3BinaryArr)), key2BinaryArr)), keyBinaryArr);

                for (int i = 0; i < XORBinaryArr.Length; i++)
                {
                    if (i < 8)
                    {
                        part1[i] = XORBinaryArr[i];
                    }
                    else if (i > 7)
                    {
                        part2[i - 8] = XORBinaryArr[i];
                    }
                }


                string strPart1 = new string(part1);
                string strPart2 = new string(part2);

                Array.Clear(part1, 0, part1.Length);
                Array.Clear(part2, 0, part2.Length);
                int asciDegerler1 = Convert.ToInt32(strPart1, 2);
                int asciDegerler2 = Convert.ToInt32(strPart2, 2);
                char harf1 = (char)asciDegerler1;
                char harf2 = (char)asciDegerler2;
                cozulmusCevap = cozulmusCevap + harf1 + harf2;


            }
            mtrTxtPlain.Text = cozulmusCevap;

        }

        byte[] CompressedData;
        byte[] compressedAndEncryptedData;
        private void mtrBtnSend_Click(object sender, EventArgs e)
        {
            Mesaj msg = new Mesaj();
            msg.mesaji = mtrTxtPlain.Text;
            msg.shaMi = mtrChbSHA256.Checked;
            msg.spnMi = mtrChbSpn.Checked;

            if (mtrTxtPlain.Text.Length > 200)
            {
                MessageBox.Show("Göndereceğiniz mesaj en fazla 200 karakter olmalıdır!");
                mtrTxtPlain.Clear();
            }
            else
            {
                if (fName == "")
                {
                    msg.Data = null;
                }
                else
                {
                    byte[] fileName = Encoding.UTF8.GetBytes(fName); //file name
                    byte[] fileData = File.ReadAllBytes(mtrTxtSendFileName.Text); //file
                    byte[] fileNameLen = BitConverter.GetBytes(fileName.Length); //lenght of file name
                    clientData = new byte[4 + fileName.Length + fileData.Length];

                    fileNameLen.CopyTo(clientData, 0);
                    fileName.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileName.Length);

                    CompressedData = Compress(clientData);
                    compressedAndEncryptedData = Encrypt(CompressedData, key, iv);

                    mtrTxtFilePath.AppendText("Preparing File To Send");
                    msg.Data = compressedAndEncryptedData;
                    MessageBox.Show("File Uploaded");
                }


                bf.Serialize(stream, msg);
                stream.Flush();
                mtrTxtSendFileName.Clear();
                mtrTxtFilePath.Clear();
                mtrTxtPlain.Clear();
                mtrChipTxt.Clear();
                mtrChbSHA256.Checked = false;
                mtrChbSpn.Checked = false;
            }
        }

        public byte[] oncekiData = null;

        byte[] decryptedbutCompressedData;
        byte[] solvedData;
        private void mtrBtnOnayla_Click(object sender, EventArgs e)
        {

            if (mtrTxtSifre.Text == sifre.ToString())  // şifre çözme 
            {
                if (realData == null)
                {

                }
                else
                {
                    decryptedbutCompressedData = Decrypt(realData, key, iv);
                    solvedData = Decompress(decryptedbutCompressedData);
                    fileNameLenght = BitConverter.ToInt32(solvedData, 0);
                    fileName = Encoding.UTF8.GetString(solvedData, 4, fileNameLenght);
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // masaüstüne indirecek kod
                    path += "//";
                    receivedPath = path + fileName;
                    buffer = new byte[solvedData.Length - 4 - fileNameLenght];
                    buffer = solvedData.Skip(4 + fileNameLenght).ToArray();
                    File.WriteAllBytes(receivedPath, buffer);
                    oncekiData = solvedData;
                    mtrLblFileInformation.Text = "";
                    MessageBox.Show("Dosya Başarıyla indirildi!");
                }




                if (spnMidir == true & shaMidir == true)
                {

                    spnCoz(mtrTxtPlain.Text);
                }
                else if (spnMidir == true & shaMidir == false)
                {
                    spnCoz(mtrTxtPlain.Text);
                }
                else if (spnMidir == false & shaMidir == true)
                {
                    MessageBox.Show("Gönderilen mesaj SHA256 formatında olduğu için çözümlenemez!");
                }
                else
                {

                }
                spnMidir = false;
                shaMidir = false;
            }
            else
            {
                MessageBox.Show("Hatalı Şifre!");
                mtrTxtSifre.Clear();
            }

        }


        private void mtrTxtPlain_TextChanged(object sender, EventArgs e)
        {
            mtrChipTxt.Clear();
            if (mtrChbSpn.Checked == true & mtrChbSHA256.Checked == true)
            {
                mtrChipTxt.Text = Spn(hash(mtrTxtPlain.Text));
            }
            else if (mtrChbSHA256.Checked == true)
            {
                mtrChipTxt.Text = hash(mtrTxtPlain.Text);
            }
            else if (mtrChbSpn.Checked == true)
            {
                mtrChipTxt.Text = Spn(mtrTxtPlain.Text);
            }
        }



        private void mtrChbSHA256_CheckedChanged(object sender, EventArgs e)
        {
            mtrChipTxt.Clear();
            if (mtrChbSpn.Checked == true & mtrChbSHA256.Checked == true)
            {

                mtrChipTxt.Text = Spn(hash(mtrTxtPlain.Text));
            }
            else if (mtrChbSHA256.Checked == true)
            {
                mtrChipTxt.Text = hash(mtrTxtPlain.Text);
            }
            else if (mtrChbSpn.Checked == true)
            {
                mtrChipTxt.Text = Spn(mtrTxtPlain.Text);
            }
        }

        private void mtrChbSpn_CheckedChanged(object sender, EventArgs e)
        {
            mtrChipTxt.Clear();
            if (mtrChbSpn.Checked == true & mtrChbSHA256.Checked == true)
            {
                mtrChipTxt.Text = Spn(hash(mtrTxtPlain.Text));
            }
            else if (mtrChbSHA256.Checked == true)
            {
                mtrChipTxt.Text = hash(mtrTxtPlain.Text);
            }
            else if (mtrChbSpn.Checked == true)
            {
                mtrChipTxt.Text = Spn(mtrTxtPlain.Text);
            }
        }

        string splitter = "'\\'";
        string fName = "";
        string[] split = null;
        byte[] clientData;
        private void mtrBtnBrowse_Click(object sender, EventArgs e)
        {
            char[] delimiter = splitter.ToCharArray();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mtrTxtSendFileName.Text = openFileDialog1.FileName;
                mtrTxtFilePath.AppendText("Selected file " + mtrTxtSendFileName.Text);

            }
            else
            {
                mtrTxtFilePath.AppendText("Please Select any one file to send");

            }

            split = mtrTxtSendFileName.Text.Split(delimiter);
            int limit = split.Length;
            fName = split[limit - 1].ToString();
            if (mtrTxtSendFileName.Text != null)
                mtrBtnBrowse.Enabled = true;
        }

        private void mtrChipTxt_TextChanged(object sender, EventArgs e)
        {
            if (mtrTxtPlain.Text == "")
            {
                mtrChipTxt.Clear();
            }
        }
    }
}