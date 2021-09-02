using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PrjAdoFirstApplication
{
    //Model Class
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            return Id + "\t" + Name + "\t" + Age;
        }
    }
    class DataAccessLayer
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd = null;
        static string connection = ConfigurationManager.ConnectionStrings["dbStudycon"].ConnectionString;
        Student1 studentobj = new Student1();
        List<Student1> students=new List<Student1>();
        #region Connection
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection(connection);
            con.Open();
            return con;
        }
        #endregion
  
        public int? GetAge(int sid)
        {
            con = GetConnection();
            cmd = new SqlCommand("select Age from  Students where id=@Stuid", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("@Stuid", sid));

            studentobj.Age =Convert.ToInt32(cmd.ExecuteScalar());
                       
            return studentobj.Age;
        }

        public Student1 GetStudenyById(int sid)
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from  Students where id=@Stuid", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("@Stuid", sid));
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            studentobj.Id = (int)rd[0];
            studentobj.Name = (string)rd[1];
            studentobj.Age = (int)rd[2];
            return studentobj;
        }
        public List<Student1> GetAllStudents()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from  Students ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                {
                studentobj = new Student1();
                studentobj.Id = (int)rd[0];
                studentobj.Name = (string)rd[1];
                studentobj.Age = (int)rd[2];
                students.Add(studentobj);
            }
            return students;
        }


    }

    class BusinessAccessLayer
    {
        DataAccessLayer Dalobj = new DataAccessLayer();
        Student1 studal=new Student1();
      public string CheckAge(int sid)
        {
            //  studal = Dalobj.GetAge( s);
            studal.Age = Dalobj.GetAge(sid);
            if (studal.Age!=null && studal.Age > 0)
            {
                return "Valid";
            }
            else
            {
                return ("Invalid");
            }
        }
        public string CheckPlacementAge(int sid)
        {
            //  studal = Dalobj.GetAge( s);
            studal.Age = Dalobj.GetAge(sid);
            if (studal.Age != null && studal.Age > 21)
            {
                return "Valid";
            }
            else
            {
                return ("Invalid");
            }
        }

        public string CheckVotingAge(int sid)
        {
            //  studal = Dalobj.GetAge( s);
            studal.Age = Dalobj.GetAge(sid);
            if (studal.Age != null && studal.Age > 18)
            {
                return "Valid";
            }
            else
            {
                return ("Invalid");
            }
        }

        public Student1 GetStudentByID(int sid)
        {
           return  Dalobj.GetStudenyById(sid);
        }
        public List<Student1> GetAllStudents()
        {
            return Dalobj.GetAllStudents();
        }

    }

    //Presentation Layer
    class StudentUI
    {
	    BusinessAccessLayer balobj = new BusinessAccessLayer();
        Student1 student = new Student1();

	    public void AcceptAge()
	    {
		    Console.WriteLine("Enter the student Id");
            student.Id = int.Parse(Console.ReadLine());
            string result = balobj.CheckPlacementAge(student.Id);
            Console.WriteLine( "The Students Age is {0 }",result);
            Console.WriteLine(student.Age);
	    }
        public void DisplayStudent()
        {
            Console.WriteLine("Enter the student Id");
            student.Id = int.Parse(Console.ReadLine());
            Student1 result = balobj.GetStudentByID(student.Id);
            Console.WriteLine("The Student Details are");
            Console.WriteLine(result);
        }
        public void DisplayAllStudents()
        {
            List<Student1> students=balobj.GetAllStudents();
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main()
        {
            
            StudentUI studentui=new StudentUI();
            studentui.DisplayAllStudents();
	        studentui.AcceptAge();
            studentui.DisplayStudent();
            Console.Read();
        }
    }
}
