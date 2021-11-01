using First.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Database
{
    class FirstContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<QRCode> QRCodes { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
       
    }
}
