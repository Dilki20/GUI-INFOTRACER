using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Model
{
    class Shop
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopCategory { get; set; }
        public string  Email{ get; set; }
        public int ContactNo { get; set; }
        public Address Address { get; set; }

    }
}
