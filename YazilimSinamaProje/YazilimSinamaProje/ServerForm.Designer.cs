
namespace YazilimSinamaProje
{
    partial class ServerForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.mtrTxtPlain = new MetroFramework.Controls.MetroTextBox();
            this.lblPlain = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtrBtnSend = new MetroFramework.Controls.MetroButton();
            this.mtrBtnOnayla = new MetroFramework.Controls.MetroButton();
            this.mtrTxtSifre = new MetroFramework.Controls.MetroTextBox();
            this.mtrChbSHA256 = new MetroFramework.Controls.MetroCheckBox();
            this.mtrChbSpn = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtrLblFileInformation = new MetroFramework.Controls.MetroLabel();
            this.mtrTxtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.mtrTxtSendFileName = new MetroFramework.Controls.MetroTextBox();
            this.mtrBtnBrowse = new MetroFramework.Controls.MetroButton();
            this.mtrLblSifre = new MetroFramework.Controls.MetroLabel();
            this.mtrLblUyari = new MetroFramework.Controls.MetroLabel();
            this.mtrChipTxt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // mtrTxtPlain
            // 
            // 
            // 
            // 
            this.mtrTxtPlain.CustomButton.Image = null;
            this.mtrTxtPlain.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.mtrTxtPlain.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtPlain.CustomButton.Name = "";
            this.mtrTxtPlain.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.mtrTxtPlain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrTxtPlain.CustomButton.TabIndex = 1;
            this.mtrTxtPlain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrTxtPlain.CustomButton.UseSelectable = true;
            this.mtrTxtPlain.CustomButton.Visible = false;
            this.mtrTxtPlain.DisplayIcon = true;
            this.mtrTxtPlain.Icon = ((System.Drawing.Image)(resources.GetObject("mtrTxtPlain.Icon")));
            this.mtrTxtPlain.Lines = new string[0];
            this.mtrTxtPlain.Location = new System.Drawing.Point(17, 87);
            this.mtrTxtPlain.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtPlain.MaxLength = 32767;
            this.mtrTxtPlain.Multiline = true;
            this.mtrTxtPlain.Name = "mtrTxtPlain";
            this.mtrTxtPlain.PasswordChar = '\0';
            this.mtrTxtPlain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrTxtPlain.SelectedText = "";
            this.mtrTxtPlain.SelectionLength = 0;
            this.mtrTxtPlain.SelectionStart = 0;
            this.mtrTxtPlain.ShortcutsEnabled = true;
            this.mtrTxtPlain.Size = new System.Drawing.Size(196, 47);
            this.mtrTxtPlain.TabIndex = 0;
            this.mtrTxtPlain.UseSelectable = true;
            this.mtrTxtPlain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrTxtPlain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtrTxtPlain.TextChanged += new System.EventHandler(this.mtrTxtPlain_TextChanged);
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(17, 68);
            this.lblPlain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(63, 19);
            this.lblPlain.TabIndex = 1;
            this.lblPlain.Text = "Plain Text";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 158);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Cipher Text";
            // 
            // mtrBtnSend
            // 
            this.mtrBtnSend.Location = new System.Drawing.Point(134, 224);
            this.mtrBtnSend.Margin = new System.Windows.Forms.Padding(2);
            this.mtrBtnSend.Name = "mtrBtnSend";
            this.mtrBtnSend.Size = new System.Drawing.Size(79, 28);
            this.mtrBtnSend.TabIndex = 4;
            this.mtrBtnSend.Text = "Send";
            this.mtrBtnSend.UseSelectable = true;
            this.mtrBtnSend.Click += new System.EventHandler(this.mtrBtnSend_Click);
            // 
            // mtrBtnOnayla
            // 
            this.mtrBtnOnayla.Location = new System.Drawing.Point(134, 303);
            this.mtrBtnOnayla.Margin = new System.Windows.Forms.Padding(2);
            this.mtrBtnOnayla.Name = "mtrBtnOnayla";
            this.mtrBtnOnayla.Size = new System.Drawing.Size(79, 28);
            this.mtrBtnOnayla.TabIndex = 5;
            this.mtrBtnOnayla.Text = "Onayla";
            this.mtrBtnOnayla.UseSelectable = true;
            this.mtrBtnOnayla.Click += new System.EventHandler(this.mtrBtnOnayla_Click);
            // 
            // mtrTxtSifre
            // 
            // 
            // 
            // 
            this.mtrTxtSifre.CustomButton.Image = null;
            this.mtrTxtSifre.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.mtrTxtSifre.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtSifre.CustomButton.Name = "";
            this.mtrTxtSifre.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtrTxtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrTxtSifre.CustomButton.TabIndex = 1;
            this.mtrTxtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrTxtSifre.CustomButton.UseSelectable = true;
            this.mtrTxtSifre.CustomButton.Visible = false;
            this.mtrTxtSifre.DisplayIcon = true;
            this.mtrTxtSifre.Icon = ((System.Drawing.Image)(resources.GetObject("mtrTxtSifre.Icon")));
            this.mtrTxtSifre.Lines = new string[0];
            this.mtrTxtSifre.Location = new System.Drawing.Point(17, 267);
            this.mtrTxtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtSifre.MaxLength = 32767;
            this.mtrTxtSifre.Name = "mtrTxtSifre";
            this.mtrTxtSifre.PasswordChar = '●';
            this.mtrTxtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrTxtSifre.SelectedText = "";
            this.mtrTxtSifre.SelectionLength = 0;
            this.mtrTxtSifre.SelectionStart = 0;
            this.mtrTxtSifre.ShortcutsEnabled = true;
            this.mtrTxtSifre.Size = new System.Drawing.Size(196, 32);
            this.mtrTxtSifre.TabIndex = 6;
            this.mtrTxtSifre.UseSelectable = true;
            this.mtrTxtSifre.UseSystemPasswordChar = true;
            this.mtrTxtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrTxtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtrChbSHA256
            // 
            this.mtrChbSHA256.AutoSize = true;
            this.mtrChbSHA256.Location = new System.Drawing.Point(260, 102);
            this.mtrChbSHA256.Margin = new System.Windows.Forms.Padding(2);
            this.mtrChbSHA256.Name = "mtrChbSHA256";
            this.mtrChbSHA256.Size = new System.Drawing.Size(64, 15);
            this.mtrChbSHA256.TabIndex = 7;
            this.mtrChbSHA256.Text = "SHA256";
            this.mtrChbSHA256.UseSelectable = true;
            this.mtrChbSHA256.CheckedChanged += new System.EventHandler(this.mtrChbSHA256_CheckedChanged);
            // 
            // mtrChbSpn
            // 
            this.mtrChbSpn.AutoSize = true;
            this.mtrChbSpn.Location = new System.Drawing.Point(260, 144);
            this.mtrChbSpn.Margin = new System.Windows.Forms.Padding(2);
            this.mtrChbSpn.Name = "mtrChbSpn";
            this.mtrChbSpn.Size = new System.Drawing.Size(45, 15);
            this.mtrChbSpn.TabIndex = 8;
            this.mtrChbSpn.Text = "SPN";
            this.mtrChbSpn.UseSelectable = true;
            this.mtrChbSpn.CheckedChanged += new System.EventHandler(this.mtrChbSpn_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 249);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Şifre";
            // 
            // mtrLblFileInformation
            // 
            this.mtrLblFileInformation.AutoSize = true;
            this.mtrLblFileInformation.Location = new System.Drawing.Point(213, 239);
            this.mtrLblFileInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mtrLblFileInformation.Name = "mtrLblFileInformation";
            this.mtrLblFileInformation.Size = new System.Drawing.Size(0, 0);
            this.mtrLblFileInformation.TabIndex = 26;
            // 
            // mtrTxtFilePath
            // 
            // 
            // 
            // 
            this.mtrTxtFilePath.CustomButton.Image = null;
            this.mtrTxtFilePath.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.mtrTxtFilePath.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtFilePath.CustomButton.Name = "";
            this.mtrTxtFilePath.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtrTxtFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrTxtFilePath.CustomButton.TabIndex = 1;
            this.mtrTxtFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrTxtFilePath.CustomButton.UseSelectable = true;
            this.mtrTxtFilePath.CustomButton.Visible = false;
            this.mtrTxtFilePath.DisplayIcon = true;
            this.mtrTxtFilePath.Icon = ((System.Drawing.Image)(resources.GetObject("mtrTxtFilePath.Icon")));
            this.mtrTxtFilePath.Lines = new string[0];
            this.mtrTxtFilePath.Location = new System.Drawing.Point(409, 134);
            this.mtrTxtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtFilePath.MaxLength = 32767;
            this.mtrTxtFilePath.Name = "mtrTxtFilePath";
            this.mtrTxtFilePath.PasswordChar = '\0';
            this.mtrTxtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrTxtFilePath.SelectedText = "";
            this.mtrTxtFilePath.SelectionLength = 0;
            this.mtrTxtFilePath.SelectionStart = 0;
            this.mtrTxtFilePath.ShortcutsEnabled = true;
            this.mtrTxtFilePath.Size = new System.Drawing.Size(174, 21);
            this.mtrTxtFilePath.TabIndex = 25;
            this.mtrTxtFilePath.UseSelectable = true;
            this.mtrTxtFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrTxtFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtrTxtSendFileName
            // 
            // 
            // 
            // 
            this.mtrTxtSendFileName.CustomButton.Image = null;
            this.mtrTxtSendFileName.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.mtrTxtSendFileName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtSendFileName.CustomButton.Name = "";
            this.mtrTxtSendFileName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtrTxtSendFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrTxtSendFileName.CustomButton.TabIndex = 1;
            this.mtrTxtSendFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrTxtSendFileName.CustomButton.UseSelectable = true;
            this.mtrTxtSendFileName.CustomButton.Visible = false;
            this.mtrTxtSendFileName.DisplayIcon = true;
            this.mtrTxtSendFileName.Icon = ((System.Drawing.Image)(resources.GetObject("mtrTxtSendFileName.Icon")));
            this.mtrTxtSendFileName.Lines = new string[0];
            this.mtrTxtSendFileName.Location = new System.Drawing.Point(409, 87);
            this.mtrTxtSendFileName.Margin = new System.Windows.Forms.Padding(2);
            this.mtrTxtSendFileName.MaxLength = 32767;
            this.mtrTxtSendFileName.Name = "mtrTxtSendFileName";
            this.mtrTxtSendFileName.PasswordChar = '\0';
            this.mtrTxtSendFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrTxtSendFileName.SelectedText = "";
            this.mtrTxtSendFileName.SelectionLength = 0;
            this.mtrTxtSendFileName.SelectionStart = 0;
            this.mtrTxtSendFileName.ShortcutsEnabled = true;
            this.mtrTxtSendFileName.Size = new System.Drawing.Size(174, 21);
            this.mtrTxtSendFileName.TabIndex = 24;
            this.mtrTxtSendFileName.UseSelectable = true;
            this.mtrTxtSendFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrTxtSendFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtrBtnBrowse
            // 
            this.mtrBtnBrowse.Location = new System.Drawing.Point(501, 174);
            this.mtrBtnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.mtrBtnBrowse.Name = "mtrBtnBrowse";
            this.mtrBtnBrowse.Size = new System.Drawing.Size(81, 29);
            this.mtrBtnBrowse.TabIndex = 23;
            this.mtrBtnBrowse.Text = "Browse";
            this.mtrBtnBrowse.UseSelectable = true;
            this.mtrBtnBrowse.Click += new System.EventHandler(this.mtrBtnBrowse_Click);
            // 
            // mtrLblSifre
            // 
            this.mtrLblSifre.AutoSize = true;
            this.mtrLblSifre.Location = new System.Drawing.Point(260, 68);
            this.mtrLblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mtrLblSifre.Name = "mtrLblSifre";
            this.mtrLblSifre.Size = new System.Drawing.Size(63, 19);
            this.mtrLblSifre.TabIndex = 27;
            this.mtrLblSifre.Text = "Şifre Türü";
            // 
            // mtrLblUyari
            // 
            this.mtrLblUyari.AutoSize = true;
            this.mtrLblUyari.Location = new System.Drawing.Point(17, 136);
            this.mtrLblUyari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mtrLblUyari.Name = "mtrLblUyari";
            this.mtrLblUyari.Size = new System.Drawing.Size(211, 19);
            this.mtrLblUyari.TabIndex = 28;
            this.mtrLblUyari.Text = "Lütfen en fazla 200 karakter giriniz.";
            // 
            // mtrChipTxt
            // 
            // 
            // 
            // 
            this.mtrChipTxt.CustomButton.Image = null;
            this.mtrChipTxt.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.mtrChipTxt.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtrChipTxt.CustomButton.Name = "";
            this.mtrChipTxt.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.mtrChipTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtrChipTxt.CustomButton.TabIndex = 1;
            this.mtrChipTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtrChipTxt.CustomButton.UseSelectable = true;
            this.mtrChipTxt.CustomButton.Visible = false;
            this.mtrChipTxt.DisplayIcon = true;
            this.mtrChipTxt.Icon = ((System.Drawing.Image)(resources.GetObject("mtrChipTxt.Icon")));
            this.mtrChipTxt.Lines = new string[0];
            this.mtrChipTxt.Location = new System.Drawing.Point(17, 176);
            this.mtrChipTxt.Margin = new System.Windows.Forms.Padding(2);
            this.mtrChipTxt.MaxLength = 32767;
            this.mtrChipTxt.Multiline = true;
            this.mtrChipTxt.Name = "mtrChipTxt";
            this.mtrChipTxt.PasswordChar = '\0';
            this.mtrChipTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtrChipTxt.SelectedText = "";
            this.mtrChipTxt.SelectionLength = 0;
            this.mtrChipTxt.SelectionStart = 0;
            this.mtrChipTxt.ShortcutsEnabled = true;
            this.mtrChipTxt.Size = new System.Drawing.Size(196, 44);
            this.mtrChipTxt.TabIndex = 29;
            this.mtrChipTxt.UseSelectable = true;
            this.mtrChipTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtrChipTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtrChipTxt.TextChanged += new System.EventHandler(this.mtrChipTxt_TextChanged);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.mtrChipTxt);
            this.Controls.Add(this.mtrLblUyari);
            this.Controls.Add(this.mtrLblSifre);
            this.Controls.Add(this.mtrLblFileInformation);
            this.Controls.Add(this.mtrTxtFilePath);
            this.Controls.Add(this.mtrTxtSendFileName);
            this.Controls.Add(this.mtrBtnBrowse);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtrChbSpn);
            this.Controls.Add(this.mtrChbSHA256);
            this.Controls.Add(this.mtrTxtSifre);
            this.Controls.Add(this.mtrBtnOnayla);
            this.Controls.Add(this.mtrBtnSend);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.mtrTxtPlain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Server Form";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtrTxtPlain;
        private MetroFramework.Controls.MetroLabel lblPlain;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mtrBtnSend;
        private MetroFramework.Controls.MetroButton mtrBtnOnayla;
        private MetroFramework.Controls.MetroTextBox mtrTxtSifre;
        private MetroFramework.Controls.MetroCheckBox mtrChbSHA256;
        private MetroFramework.Controls.MetroCheckBox mtrChbSpn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mtrLblFileInformation;
        private MetroFramework.Controls.MetroTextBox mtrTxtFilePath;
        private MetroFramework.Controls.MetroTextBox mtrTxtSendFileName;
        private MetroFramework.Controls.MetroButton mtrBtnBrowse;
        private MetroFramework.Controls.MetroLabel mtrLblSifre;
        private MetroFramework.Controls.MetroLabel mtrLblUyari;
        private MetroFramework.Controls.MetroTextBox mtrChipTxt;
    }
}

