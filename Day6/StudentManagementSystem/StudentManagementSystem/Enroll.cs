using Aug11;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{   // DAO Layer
    class Enroll//Cart...
    {
        private Student student;//User
        private Course course;//MenuItem
        private DateTime enrollmentDate;

        public List <Course> CourseList = new List <Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public Enroll()
        {

        }

        public Student EnStudent{ get;set; }
        public Course EnCourse { get; set; }
        public DateTime EnDate { get; set; }

        static SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCon"].ConnectionString);
 public void introduce(Course course)//
        {   
            if(course.CourseId!="" && course.CourseName!="" && course.CourseDuration!="" && course.CourseFees!=0)
            {

                SqlCommand cmd = new SqlCommand("procInsertCourse", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cid", course.CourseId);
                cmd.Parameters.AddWithValue("@cname", course.CourseName);
                cmd.Parameters.AddWithValue("@cdur", course.CourseDuration);
                cmd.Parameters.AddWithValue("@cfees", course.CourseFees);

                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        CourseList.Add(course);
                        Console.WriteLine("Course {0} added successfully", course.CourseName);
                    }

                }

                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    cnn.Close();
                }
            }

           else
           {
                throw new StudentException("Please enter all the details of the course");
           }
        }
              public List<Course> listOfCourses()//
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSE", cnn);
            SqlDataReader rd = cmd.ExecuteReader();

            try
            {
                while (rd.Read())
                {
                    Course c = new Course((string)rd[0], (string)rd[1], (string)rd[2], float.Parse(rd[3].ToString()));
                    CourseList.Add(c);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                cnn.Close();
            }


            if (CourseList.Count != 0)
                return CourseList;
            else
                throw new StudentException("No courses to show");
        }
 public void register(Student student)//
        {
            if (student.Id != "" && student.Name != "" && student.DOB != null)//check if none of the fields are empty
            {

                SqlCommand cmd = new SqlCommand("procInsertStudent", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stid", student.Id);
                cmd.Parameters.AddWithValue("@stname", student.Name);
                cmd.Parameters.AddWithValue("@stdob", student.DOB);

                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        StudentList.Add(student);
                        Console.WriteLine("Student named {0} added successfully", student.Name);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    cnn.Close();
                }
            }

            else
            {
                throw new StudentException("Incomplete student details");
            }

        }
    public List<Student> listOfStudents()//
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT", cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            try
            {
                while (rd.Read())
                {
                    Student s = new Student((string)rd[0], (string)rd[1], (DateTime)rd[2]);
                    StudentList.Add(s);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                cnn.Close();
            }

            if (StudentList.Count!=0)
                return StudentList;
            else
                throw new StudentException("No students to show");
        }
  public void enroll(Student student, Course course)//
        {
            if(student!=null && course!=null)
            {
                SqlCommand cmd = new SqlCommand("procEnroll", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stid", student.Id);
                cmd.Parameters.AddWithValue("@cid", course.CourseId);
                cmd.Parameters.AddWithValue("@enrolldate", DateTime.UtcNow);

                if (cnn.State == System.Data.ConnectionState.Open)
                    cnn.Close();
                cnn.Open();

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        EnrollList.Add(new Enroll(student,course, DateTime.UtcNow));
                        Console.WriteLine("Student named {0} enrolled for course {1} successfully", student.Name,course.CourseName);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    cnn.Close();
                }
            }
            
            else
            {
                throw new StudentException("Invalid student or course");
            }
        }
   public List<Enroll> listOfEnrollments()//
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ENROLL", cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            try
            {
                while (rd.Read())
                {
                    
                    Enroll e = new Enroll(getStudentById((string)rd[0]),getCourseById((string)rd[1]), (DateTime)rd[3]);
                    EnrollList.Add(e);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                cnn.Close();
            }

            if (EnrollList.Count!=0)
                return EnrollList;
            else
                throw new StudentException("No Enrollments to show");
            
        }
  public Student getStudentById(string id)//get student with id from db
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("procStudentById", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stid", id);
            SqlDataReader rd = cmd.ExecuteReader();

            
            if (rd.Read())
            {
                Student s = new Student((string)rd[0], (string)rd[1], (DateTime)rd[2]);
                //cnn.Close();
                return s;
            }

            else
            {
                throw new StudentException("No such student exists");
            }

        }
    public Course getCourseById(string id)//get course with id from db
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Close();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("procCourseById", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cid", id);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                Course c = new Course((string)rd[0], (string)rd[1], (string)rd[2], float.Parse(rd[3].ToString()));
                //cnn.Close();
                return c;
            }

            else
                throw new StudentException("No such course exists");

        }


    }

        


}
