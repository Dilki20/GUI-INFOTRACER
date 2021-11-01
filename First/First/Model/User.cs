using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Model
{
    class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC_NO { get; set; }
        public int MobileNo { get; set; }
        public Address Address { get; set; }
        public QRCode QRCode { get; set; }
      
    }
}
