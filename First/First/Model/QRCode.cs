using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Model
{
    class QRCode
    {
        public int QRCodeID { get; set; }
        public string QRData { get; set; }
        public byte[] ImageToByte { get; set; }
    }
}
