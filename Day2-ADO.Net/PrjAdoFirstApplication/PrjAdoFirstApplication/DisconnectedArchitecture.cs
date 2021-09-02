using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PrjAdoFirstApplication
{
    class DisconnectedArchitecture
    {
        static void Main()
        {
             string connection = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            SqlDataAdapter da = new SqlDataAdapter("select * from Region;select * from customers", con);
           
            con.Open();
            DataSet ds = new DataSet();

          
            //Select Command
              da.Fill(ds); //region is userdefined name
            con.Close();

            foreach (var item in ds.Tables)
            {
                DataTable dt = ds.Tables[item.ToString()];

                Console.WriteLine("Printing the contents of {0}", item);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        Console.Write(row[col] + "\t");
                    Console.WriteLine();

                    Console.WriteLine("".PadLeft(100, '='));
                }
                Console.ReadKey();
            }
               
          
               
            
               
            da = new SqlDataAdapter("select * from employees", con);
            da.Fill(ds, "emptax");
            DataTable dt1 = ds.Tables["emptax"];
            foreach (DataRow row in dt1.Rows)
            {
                foreach (DataColumn col in dt1.Columns)
                    Console.Write(row[col]+"\t");
                Console.WriteLine(
                    );
                Console.WriteLine("".PadLeft(100, '='));
            }


            Console.Read();
             



        }
    }
}
