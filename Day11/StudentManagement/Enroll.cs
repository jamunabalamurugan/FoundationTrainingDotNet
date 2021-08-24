using Aug11;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{   // DAO Layer
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public List <Course> CourseList = new List <Course>();
        public List<Student> StudentList = new List<Student>();
        public List<Enroll> EnrollList = new List<Enroll>();

        Enroll(Student student, Course course, DateTime enrollmentDate)
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

       
        public void introduce(Course course)
        {
            if(course.CourseId!="" && course.CourseName!="" && course.CourseDuration!="" && course.CourseFees!=0)
            {
                CourseList.Add(course);
                Console.WriteLine("Course {0} added successfully", course.CourseName);
            }

           else
           {
                throw new StudentException("Please enter all the details of the course");
           }

        }

        public List<Course> listOfCourses()
        {   if(CourseList.Count!=0)
                return CourseList;
            else
                throw new StudentException("No courses to show");
        }

        public void register(Student student,string course)//Get course using coursename from db & check if course valid
        {
            if(student.Id!="" && student.Name!="" && student.DOB!=null && course!="")//check if none of the fields are empty
            {
                StudentList.Add(student);
                EnrollList.Add(new Enroll(student, new Course(), DateTime.UtcNow));
                Console.WriteLine("Student named {0} added successfully", student.Name);
            }

            else
            {
                throw new StudentException("Invalid student or course");
            }

        }

        public List<Student> listOfStudents()
        {   
            if(StudentList.Count!=0)
                return StudentList;
            else
                throw new StudentException("No students to show");

        }

        public void enroll(Student student, Course course)
        {
            if(student.Id != "" && student.Name != "" && student.DOB != null && 
                course.CourseId!= "" && course.CourseName!="" && course.CourseDuration!="" && course.CourseFees!=0)
            {
                EnrollList.Add(new Enroll(student, course, enrollmentDate));
                Console.WriteLine("Student {0} added for course {1} successfully", student.Name, course.CourseName);
            }
            
            else
            {
                throw new StudentException("Invalid student or course");
            }
        }

        public List<Enroll> listOfEnrollments()
        {   
            if(EnrollList.Count!=0)
                return EnrollList;
            else
                throw new StudentException("No ENrollments to show");
            
        }

        public Student getStudentById(string id)//get student with id from db
        {   
            Student s = new Student();
            return s;
        }

    }

}
