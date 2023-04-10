using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDB.Configurations
{
    public static class ConnectionString
    {
        public static string MsSqlConnection => @"Server=.DESKTOP-2212VCT\SQLEXPRESS;Database=testing;Trusted_Connection=True;Trust Server Certificate=true;";
}
}
