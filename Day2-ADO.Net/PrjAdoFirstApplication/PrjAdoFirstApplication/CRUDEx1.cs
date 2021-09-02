using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PrjAdoFirstApplication
{
    class CRUDEx1
    {
        public static void Main()
        {
            SqlConnection con=null;
            SqlCommand cmd = null;
            try
            {
                //Provide the Connection Details by passing connect string to the constructor 
con = new SqlConnection("Data Source=MSBEEYS\\HBSQLEXPRESS;Initial Catalog=Northwind;User ID=sa;Password=newuser123#");  

                Console.WriteLine("Connected");
                con.Open();
                //Execute Scalar
                cmd = new SqlCommand("Select count(RegionId) from Region", con);
                Console.WriteLine("Total rows : {0}", Convert.ToInt32(cmd.ExecuteScalar()));

                //Select

                cmd = new SqlCommand("select * from Categories", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Console.WriteLine(dr["RegionId"] + " " + dr["RegionDescription"]);
                    Console.WriteLine(dr[0]+" " +dr[1]+" "+dr[2]);
                }


                //Insert
                /*
            //Sql Command
            //Multiple Insertion
                cmd = new SqlCommand
                ("insert into Region(RegionId,RegionDescription) " +
                "values(6,'NorthWest') ,(7,'SouthEast')", con);

           

            //Executing Insert Statement
          int rowsinserted=  cmd.ExecuteNonQuery();
            Console.WriteLine("No of rows inserted is {0}", rowsinserted);
            */
                //Delete
                /*
                cmd = new SqlCommand("delete from Region where RegionId=5",con);
               Console.WriteLine("No of rows deleted{0}", cmd.ExecuteNonQuery());
               */

                //Update






            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            finally
                {
                con.Close();
            }

            Console.Read();
        }
    }
}
