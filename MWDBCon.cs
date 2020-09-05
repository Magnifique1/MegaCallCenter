using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCallCenter
{
    class MWDBCon
    {
        public string MyConnection()
        {
            string con = @"Data Source=196.201.228.138;Initial Catalog=MEGA_WHOLESALERS;User ID=sa; Password=Change123";
            return con;
        }
    }
}
