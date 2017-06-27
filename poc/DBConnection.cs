using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace poc
{
   public  class DBConnection
    {
    public string Sqlconnection(String sql){
         SqlConnection cnn;
        string connetionString = null;
        connetionString = "Data Source=(local);Initial Catalog=HML_PURCHASE;User ID=HML;Password=HML1234";
        cnn = new SqlConnection(connetionString);     
        
           
    try
            {
                                       
                cnn.Open();
              //  SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
             //   cnn.Close();
                return ("Database connected");       
                       }
            catch (Exception ex)
            {
                Console.Write(ex);
                Console.WriteLine("Database not connected");
                Console.Read();
                return("Database not connected");
            }
        }
      
    }
}
