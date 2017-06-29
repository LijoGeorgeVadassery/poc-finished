using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace poc
{
    class Program
    {
        static void Main(string[] args)
        {
           
            String Sql;
            DataTable dt = new DataTable();
            DBConnection Dbcon = new DBConnection();
            Sql = "Select * from FIN_YEAR";
            dt=Dbcon.Sqlconnection(Sql);
            List<FinanicialYears> FinancialDetails = new List<FinanicialYears>();
            Converttype ct = new Converttype();            
            FinancialDetails =ct.BindList<FinanicialYears>(dt);
          
         }
    }
}
