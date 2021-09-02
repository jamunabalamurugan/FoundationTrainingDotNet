using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PrjAdoFirstApplication
{
    class SPEg
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        static string connection = ConfigurationManager.ConnectionStrings["Northwindconnection"].ConnectionString;
        #region Connection
        public static SqlConnection GetConnection()
        {
           con = new SqlConnection(connection);
           con.Open();
            return con;
        }
        #endregion

        #region StoreProcedurewithoutParameter
        void StoreProcedure()
        {
            con = GetConnection();

             cmd = new SqlCommand("Ten Most Expensive Products", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
            }

        }
        #endregion

        #region StoreProcedureWithParameters
        void StoreProcedurewithParameters(int id)
        {
            con = GetConnection();
            cmd = new SqlCommand("getemployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add( new SqlParameter("@empid", id));

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                // Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString());
                for (int initial = 0; initial < dr.FieldCount; initial++)
                {
                    Console.Write(dr[initial]);
                    Console.Write("\t");
                }
            }

           
        }

        #endregion
        static void Main()
        {
            SPEg sobj = new SPEg();
            sobj.StoreProcedurewithParameters(2);

            Console.Read();
        }
    }
}
