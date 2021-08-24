using Aug11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{
    class ScreenDescription : IUserInterface
    {
        //Presentation Layer
        Info info = new Info();
        Enroll en = new Enroll();

        public void showAdminScreen()//
        {
            Console.WriteLine("---Welcome to Admin Dashboard---");
            Console.WriteLine("\nEnter your choice:\n1.Show all Student Details\n2.Show all current Student Enrollments\n" +
                "3.Introduce new course\n4.Show all courses\n5.Display Student Details by ID\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    showAllStudentsScreen();
                    break;
                case 2:
                    showAllEnrollments();
                    break;
                case 3:
                    introduceNewCourseScreen();
                    break;
                case 4:
                    showAllCoursesScreen();
                    break;
                case 5:
                    showStudentDetails();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
        }

        public void showStudentScreen()//
        {
            Console.WriteLine("---Welcome to Student Center---");

            Console.WriteLine("\nEnter your choice:\n1.Register for a Course\n2.Show all Student Enrollments\n3.Show all Student Details\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllEnrollments();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }

        }

        public void showAllStudentsScreen()//
        {
            try
            {
                Console.WriteLine("---Students---");
                foreach (Student s in en.listOfStudents())
                    info.display(s);
            }

            catch(StudentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void showAllEnrollments()//
        {

            try
            {
                Console.WriteLine("---Enrollments---");
                foreach (Enroll e in en.listOfEnrollments())
                    info.display(e);
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public void showStudentDetails()//
        {
            try
            {
                Console.WriteLine("Enter student ID:");
                string Id = Console.ReadLine();
                Console.WriteLine(en.getStudentById(Id));
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void showStudentRegistrationScreen()//
        {
            try
            {
                Console.WriteLine("---Student Registration---");
                Console.WriteLine("Enter the student details to be added:");
                Console.WriteLine("Student ID:");
                string StudentId = Console.ReadLine();
                Console.WriteLine("Student Name:");
                string StudentName = Console.ReadLine();
                Console.WriteLine("Student DOB:");
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enrolled Course:");
                string course = Console.ReadLine();
                en.register(new Student(StudentId, StudentName, DOB), course);
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }

        public void showAllCoursesScreen()//
        {
            try
            {
                Console.WriteLine("---Courses---");
                foreach (Course c in en.listOfCourses())
                    info.display(c);
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void introduceNewCourseScreen()//
        {
            try
            {
                Console.WriteLine("---Add a new Course---");
                Console.WriteLine("Enter the course details to be added:");
                Console.WriteLine("Course ID:");
                string CourseId = Console.ReadLine();
                Console.WriteLine("Course Name:");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Course Duration:");
                string CourseDuration = Console.ReadLine();
                Console.WriteLine("Course Fees:");
                float CourseFees = float.Parse(Console.ReadLine());
                en.introduce(new Course(CourseId, CourseName, CourseDuration, CourseFees));
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


        public void showFirstScreen()//
        {
            
            Console.WriteLine("\nWelcome to SMS (Student Mgmt. System)  v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");

            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
