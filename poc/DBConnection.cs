using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace poc
{
   public  class DBConnection
    {       
    public DataTable Sqlconnection(String sql){
         SqlConnection cnn;
         DataTable dt = new DataTable();
        string connetionString = null;
        connetionString = "Data Source=(local);Initial Catalog=HML_PURCHASE;User ID=HML;Password=HML1234";
        cnn = new SqlConnection(connetionString);
    try {
          cnn.Open();
          SqlCommand myCommand = new SqlCommand(sql, cnn);
          SqlDataAdapter da = new SqlDataAdapter(myCommand);
          da.Fill(dt);
          cnn.Close();
          return (dt);
        }
        catch (Exception ex)
        {
          Console.Write(ex);
          Console.WriteLine("Database not connected");
          Console.Read();
          return(null);
        }
        }  
    }
}
