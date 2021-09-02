using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PrjAdoFirstApplication
{
    //Data Access Layer
    class CRUDOperation
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        static string  connection = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        #region Connection
        public static SqlConnection  GetConnection()
        {
            /* con = new SqlConnection(
             "Data Source=.;Initial Catalog=Northwind;" +
             "User ID=sa;Password=newuser123#");*/
            con = new SqlConnection(connection);
          
            con.Open();
            return con;
        }
        #endregion
        #region Display
        /// <summary>
        /// Display all the regions
        /// </summary>
        /// <returns></returns>
        public DataSet DisplayRegions()
        {
            con = GetConnection();
            cmd = new SqlCommand("select regionid,regiondescription from region", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;

        }

        public void DisplaySpecificRegion()
        {

        }
        #endregion


        #region Insert
        /// <summary>
        /// result : No of rows inserted
        /// </summary>
        /// <param name="id"></param>
        /// <param name="des"></param>
        public int InsertRegion(int id, string des)
        {
          con= GetConnection();
            cmd = new SqlCommand
                ("insert into Region(RegionId,RegionDescription) " +
                "values(@RegionId,@RegionDesc)", con);
            cmd.Parameters.AddWithValue("@RegionId", id);
            cmd.Parameters.AddWithValue("@RegionDesc", des);
            //Executing Insert Statement
            int rowsinserted = cmd.ExecuteNonQuery();
            return rowsinserted;
            //Console.WriteLine("No of rows inserted is {0}", rowsinserted);-- To Avoid output statements
        }

        #endregion

        #region Delete
        public int DeleteRegion(int getvalue)
        {
           con = GetConnection();
          
            cmd = new SqlCommand("delete Region where RegionId=@Rid", con);
            cmd.Parameters.AddWithValue("@Rid", getvalue);
            //Console.WriteLine("No of rows deleted {0}", cmd.ExecuteNonQuery());
            return cmd.ExecuteNonQuery();
        }

        #endregion
    }

    //Front End App or User Interface
    class CRUD_Method
    {
        static void Main()
        {
            CRUDOperation cobj = new CRUDOperation();//Data Access Layer object is created
            try
            {
                Console.WriteLine("Enter the operation to be performed  1:Insertion 2:Deletion 3.Display");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice ==1)
                {
                    int rid = int.Parse(Console.ReadLine());
                    string desc = Console.ReadLine();
                    Console.WriteLine( "Rows Inserted {0}",cobj.InsertRegion(rid,desc)); 
                }
                else if(Choice ==2)
                {
                    Console.WriteLine("Enter the Region Id to be Deleted");
                    int rid = Convert.ToInt32(Console.ReadLine());
                    if(cobj.DeleteRegion(rid)>0)
                        Console.WriteLine("Record Deleted Succesfully...");
                    else
                        Console.WriteLine("Could not delete record....");
                }
                else if(Choice==0)
                {
                    Environment.Exit(0);
                }
                else if(Choice==3)
                {
                    DataSet ds = cobj.DisplayRegions();
                    
                        DataTable dt = ds.Tables[0];
                                    
                    //To print Column Headings
                    foreach (DataColumn item in dt.Columns)
                    {
                        Console.Write(item+"\t");
                    }
                    Console.WriteLine();
                    //To print the rows in the result
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (var col in row.ItemArray)
                        {
                            Console.Write(col+"\t");
                        }
                        Console.WriteLine();
                    }
                        Console.ReadKey();
               
                }
               
            }
            catch(Exception exmessage)
            {
                Console.WriteLine(exmessage);
            }
          
            Console.Read();

        }
    }
}
