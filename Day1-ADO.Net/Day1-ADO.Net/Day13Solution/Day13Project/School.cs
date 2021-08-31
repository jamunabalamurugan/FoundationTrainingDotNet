using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Day13Project
{
    class School
    {
        SqlConnection conn;
        SqlDataAdapter daCourse;
        DataSet dsCourse=new DataSet();
        School()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCon"].ConnectionString);
        }

        void GetAllCourses()
        {
            //daCourse = new SqlDataAdapter("proc_GetAllCourse", conn);
            //daCourse.SelectCommand.CommandType = CommandType.StoredProcedure;
            daCourse = new SqlDataAdapter("select * from tblcourse", conn);
                       
            daCourse.Fill(dsCourse,"myCourse");//open,get the data and put it in dataset,close the connection
            Console.WriteLine("The connection state "+conn.State);
            //foreach (DataRow row in dsCourse.Tables["myCourse"].Rows)
            foreach (DataRow row in dsCourse.Tables[0].Rows)
            {
                //Console.WriteLine("Course Id "+row[0]+" name "+row[1]+" fees "+row[2]);
                Console.WriteLine("Course Id " + row["id"] + " name " + row["name"] + " fees " + row["fees"]);
            }

            //foreach (var row in dsCourse.Tables[0].Rows)
            //{
            //    Course course = new Course();
            //    course.Id = ;
            //        Console.WriteLine(course);
               
                
            //}
        }
        void InsertNewCourseToDatabase(string name,float? fees)
        {
            InsertNewCourseToDatabase(new Course(name, fees));
        }
        void InsertNewCourseToDatabase(string name)
        {
            InsertNewCourseToDatabase(new Course(name));
        }
        void InsertNewCourseToDatabase(Course course)
        {
            SqlCommand cmdInsertStudent = new SqlCommand();
            cmdInsertStudent.CommandText = "proc_InsertCourse";
            cmdInsertStudent.CommandType = CommandType.StoredProcedure;
            cmdInsertStudent.Connection = conn;
            cmdInsertStudent.Parameters.AddWithValue("@cname",course.Name);
        
            cmdInsertStudent.Parameters.AddWithValue("@cfees", course.Fees);
            conn.Open();
            int iResult = cmdInsertStudent.ExecuteNonQuery();

            //daCourse = new SqlDataAdapter();
            //daCourse.InsertCommand = new SqlCommand("proc_InsertCourse", conn);
            //daCourse.InsertCommand.CommandType = CommandType.StoredProcedure;
            //daCourse.InsertCommand.Parameters.AddWithValue("@cname", course.Name);
            //daCourse.InsertCommand.Parameters.AddWithValue("@cfees", course.Fees);
            //DataSet dataSet = new DataSet();
            //daCourse.Fill(dataSet);


            //DataRow drNew = dsCourse.Tables[0].NewRow();
            //drNew["name"] = course.Name;
            //drNew["fees"] = course.Fees;
            //dsCourse.Tables["myCourse"].Rows.Add(drNew);
            //new SqlCommandBuilder(daCourse);//generate the insert command
            //daCourse.Update(dsCourse, "myCourse");//Save the values in insert command permanently  in db
        }
        static void Main(string[] a)
        {
            School school = new School();
            school.GetAllCourses();
            //Course course = new Course();
            //course.TakeCourseDataFromUser();
            //school.InsertNewCourseToDatabase("StoreProc ADO.Net",100000f);
            //school.GetAllCourses();
            Console.ReadKey();
        }
    }
}
