using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProje
{
    [Serializable]
    public class Mesaj
    {
        public string mesaji { get; set; }

        public override string ToString()
        {
            {
                return mesaji;
            }
        }
        public bool spnMi { get; set; }
        public bool spnBool()
        {
            {
                return spnMi;
            }
        }

        public bool shaMi { get; set; }
        public bool shaBool()
        {
            {
                return shaMi;
            }
        }

        public byte[] Data { get; set; }

        public byte[] DataSend()
        {
            {
                return Data;
            }
        }
    }
}
