using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace poc
{
    class Program
    {
        static void Main(string[] args)
        {
           
            String Sql;
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from FIN_YEAR";
            Dbcon.Sqlconnection(Sql);
         }
    }
}
