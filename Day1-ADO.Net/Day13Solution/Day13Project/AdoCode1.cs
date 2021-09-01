using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoCodeDay1
{
    //Data Access Layer
    class AdoCode1
    {
        internal SqlConnection conn;
        internal SqlCommand cmd;
        internal SqlDataReader dr;
        internal void Connect()
        {
            conn = new SqlConnection(@"data source=MSBEEYS\HBSQLEXPRESS;initial catalog=HRDB;user id=sa;password=newuser123#");
            //conn = new SqlConnection(@"Data source=MSBEEYS\HBSQLEXPRESS;initial catalog=hrdb;integrated security=true");
            conn.Open();
        }/// <summary>
         /// Fetches the employee details from tblemployeeinfo from hrdb
         /// </summary>
        internal void GetEmployees()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "select * from northwind.dbo.categories";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                    return;
                Console.WriteLine();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.Write(dr.GetName(i)+"\t");
                }
                Console.WriteLine("\n=========================================================");
                while (dr.Read())
                {
                    // Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[5]);
                    for(int i=0;i<dr.FieldCount;i++)
                    {
                        Console.Write(dr[i] + "\t");
                    }
                    Console.WriteLine();
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        internal void AddNewEmployee()
        {
            cmd = new SqlCommand("insert tblemployeeinfo(employeeid,name) values(6,'Joshitha')", conn);
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                Console.WriteLine("Employee added....");
        }

        internal void UpdateEmployee()
        {
            cmd = new SqlCommand("update tblemployeeinfo set salary=salary+100 where employeeid=5", conn);
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                Console.WriteLine("Salary updated");
        }

        internal void GetCount()
        {
            cmd = new SqlCommand("select count(employeeid) from tblemployeeinfo", conn);
            var result = cmd.ExecuteScalar();
            Console.WriteLine("Count is " + result);

        }

        internal bool AddNewDept(int Depid, string Name, int Dephead)
        {
            cmd = new SqlCommand("insert tbldepartment (depid,name,dephead) values(@depid,@name,@dephead)", conn);
            //cmd.Parameters.Add("@depid", SqlDbType.Int);
            //cmd.Parameters[0].Value = Depid;
            //cmd.Parameters.Add("@name", SqlDbType.VarChar, 20);
            //cmd.Parameters[1].Value = Name;
            cmd.Parameters.AddWithValue("@depid", Depid);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@dephead", Dephead);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                return true;
            else
                return false;

        }
        internal void CloseConn()
        {
            conn.Close();
        }

        //Disconnected architecture
        internal void GetAll()
        {
            Connect();
            SqlDataAdapter sa = new SqlDataAdapter("select * from tblemployeeinfo;select * from tbldepartment",conn);
            DataSet ds = new DataSet();
            sa.Fill(ds);//open,get the data and put it in dataset,close the connection
            Console.WriteLine("Employee Details");
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    Console.WriteLine(item["employeeid"]+"\t"+item["name"]);
            //}
            //Console.WriteLine("Department Details");
            //foreach (DataRow item in ds.Tables[1].Rows)
            //{
            //    Console.WriteLine(item["depid"] + "\t" + item["name"]);
            //}
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        Console.Write(row[col]+"\t");

                    }
                    Console.WriteLine();
                    
                }
            }
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //        Console.WriteLine(row[col]);
            //    Console.WriteLine("".PadLeft(20, '='));
            //}



        }
    }
    //Presentation Layer
    class UseAdo
    {
        AdoCode1 ado = new AdoCode1();
        void CrudDepartment()
        {
            
            ado.Connect();
            Console.WriteLine("Connected");
            Console.WriteLine("Enter Depid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string DepName = Console.ReadLine();
            Console.WriteLine("Enter Dep Head");
            int hid = int.Parse(Console.ReadLine());
            bool result = ado.AddNewDept(id, DepName, hid);
            if (result)
                Console.WriteLine("Department Added");
            else
                Console.WriteLine("Sorry....There was an error");
            ado.CloseConn();
        }
        void CrudEmployee()
        {
           
            ado.Connect();
            Console.WriteLine("Connected");
           // do{           {
                try
                {
                    //ado.AddNewEmployee();
                    ado.GetEmployees();
                    //ado.UpdateEmployee();
                    ado.GetCount();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry ....try again");
                }
                Console.ReadKey();
            //} while (true);
            ado.CloseConn();
        }
        public static void Main()
        {
            UseAdo obj = new UseAdo();
            //obj.CrudEmployee();
            //obj.CrudDepartment();
            AdoCode1 ado = new AdoCode1();
            ado.GetAll();
            Console.ReadKey();
        }

    }
}
