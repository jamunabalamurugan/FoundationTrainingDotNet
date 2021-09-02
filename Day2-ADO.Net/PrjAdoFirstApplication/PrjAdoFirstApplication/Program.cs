using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PrjAdoFirstApplication
{
    class Program
    {
        SqlConnection conn;
        SqlCommand cmdGetStudents, cmdInsertStudent, cmdUpdateStudentName, cmdDeleteStudent;
        List<Student> students;
        Program()
        {

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCon"].ConnectionString);
            //conn.Open();
            //Console.WriteLine("Connection success");
        }
        void GetStudentsDataFromDatabase()
        {
            //cmdGetStudents = new SqlCommand("select * from Students",conn);
            students = new List<Student>();
            try
            {
                cmdGetStudents = new SqlCommand();
                cmdGetStudents.CommandText = "select * from Students";
                cmdGetStudents.Connection = conn;
                conn.Open();
                SqlDataReader drStudents = cmdGetStudents.ExecuteReader();
                Student student;
                while (drStudents.Read())
                {
                    student = new Student();
                    student.Id = Convert.ToInt32(drStudents[0]);
                    student.Name = drStudents[1].ToString();
                    //int age;
                    //Int32.TryParse(drStudents[2].ToString(), out age);
                    //student.Age = age;
                    try
                    {
                        student.Age = Convert.ToInt32(drStudents[2]);
                    }
                    catch (InvalidCastException ice)
                    {
                    }
                    students.Add(student);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(se.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        void PrintStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine("--------------------------------");
            }
        }
        void InsertStudentToDatabase()
        {
            Student student = new Student();
            student.TakeStudentDataFromUser();
            // insert into Students(name, age) values('Kavin', null)
            try
            {
                cmdInsertStudent = new SqlCommand();
                cmdInsertStudent.CommandText = "insert into Students(name, age) values(@studentname,@studentage)";
                cmdInsertStudent.Connection = conn;
                cmdInsertStudent.Parameters.Add("@studentname", SqlDbType.VarChar, 20);
                cmdInsertStudent.Parameters[0].Value = student.Name;
                cmdInsertStudent.Parameters.AddWithValue("@studentage", student.Age);
                conn.Open();
                int iResult = cmdInsertStudent.ExecuteNonQuery();
                if (iResult > 0)
                {
                    Console.WriteLine("Student record inserted.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("-------------------");
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
        void UpdateStudentName()
        {
            Console.WriteLine("Update Student Details");
            Console.WriteLine("****************************");
            Console.WriteLine("Please enter the student ID");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
                student = students.Where(s => s.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("No such student");
            }
            if (student != null)
            {
                Console.WriteLine("The students details: ");
                Console.WriteLine(student);
                Console.WriteLine("Please enter the Student name for updation");
                string name = Console.ReadLine();
                cmdUpdateStudentName = new SqlCommand("update students set name=@sname where id=@sid", conn);
                cmdUpdateStudentName.Parameters.AddWithValue("@sid", id);
                cmdUpdateStudentName.Parameters.AddWithValue("@sname", name);
                try
                {
                    conn.Open();
                    int iResult = cmdUpdateStudentName.ExecuteNonQuery();
                    if (iResult > 0)
                        Console.WriteLine("Student name updated");
                    else
                        Console.WriteLine("Student name not updated");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("-------------------");
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Console.WriteLine("No such student");
            }


        }

        void DeleteStudentRecordFromDatabase()
        {
            Console.WriteLine("Delete Student");
            Console.WriteLine("****************************");
            Console.WriteLine("Please enter the student ID");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);
            Student student = null;
            try
            {
                student = students.Where(s => s.Id == id).First();
            }
            catch (Exception e)
            {
                Console.WriteLine("No such student");
            }
            if (student != null)
            {
                Console.WriteLine("The studnets detais: ");
                Console.WriteLine(student);
                Console.WriteLine("Are you sure you want to delete");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "YES")
                {
                    //cmdDeleteStudent = new SqlCommand("proc_DeleteStudnet", conn);
                    //cmdDeleteStudent.CommandType = CommandType.StoredProcedure;

                    cmdDeleteStudent = new SqlCommand("delete Students where id=@sid", conn);
                    cmdDeleteStudent.Parameters.AddWithValue("@sid", id);
                    try
                    {
                        conn.Open();
                        int iResult = cmdDeleteStudent.ExecuteNonQuery();
                        if (iResult > 0)
                            Console.WriteLine("Student deleted");
                        else
                            Console.WriteLine("No record was deleted");
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("-------------------");
                        Console.WriteLine(e.StackTrace);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                    Console.WriteLine("Okay....");
            }
            else
                Console.WriteLine("No such student");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
           // program.InsertStudentToDatabase();
          //  program.GetStudentsDataFromDatabase();
           // program.PrintStudents();
          //  program.UpdateStudentName();
            program.GetStudentsDataFromDatabase();
            //program.PrintStudents();
            program.DeleteStudentRecordFromDatabase();
            program.GetStudentsDataFromDatabase();
            program.PrintStudents();
            Console.ReadKey();
        }
    }
}
