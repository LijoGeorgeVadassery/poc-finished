using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
namespace poc
{
   public class Converttype
    {

        public List<T> BindList<T>(DataTable dt)
        {
            // Example 1:
            // Get private fields + non properties
            var fields = typeof(T).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            // Example 2: Your case
            // Get all public fields
            //  var fields = typeof(T).GetFields();

            List<T> lst = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                // Create the object of T
                var ob = Activator.CreateInstance<T>();

                foreach (var fieldInfo in fields)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        string s = fieldInfo.Name;
                        string[] FieldName1 = s.Split('>');
                        s = FieldName1[0];
                        string[] FieldName2 = s.Split('<');
                        string FieldName = FieldName2[1];

                        // Matching the columns with fields
                        if (FieldName == dc.ColumnName)
                        {
                            // Get the value from the datatable cell
                            object value = dr[dc.ColumnName];

                            // Set the value into the object
                            fieldInfo.SetValue(ob, value);
                            break;
                        }
                    }
                }

                lst.Add(ob);
            }

            return lst;
        }
    }
}
