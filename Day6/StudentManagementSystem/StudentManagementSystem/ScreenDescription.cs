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
            Console.WriteLine("\n----------Welcome to Admin Dashboard----------\n");
            Console.WriteLine("\nEnter your choice:\n\n1.Show all Student Details\n2.Show all current Student Enrollments\n" +
                "3.Introduce new course\n4.Show all courses\n5.Display Student Details by ID\n6.Admit a student in university\n");
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
                case 6:
                    showStudentRegistrationScreen();
                    break;
                default:
                    Console.WriteLine("Please enter correct choice");
                    break;
            }
        }

        public void showStudentScreen()//
        {
            Console.WriteLine("\n----------Welcome to Student Center----------\n");

            Console.WriteLine("\nEnter your choice:\n\n1.Enroll for a Course\n2.Show all Student Enrollments\n3.Show all Student Details\n" +
                "4.Show all courses\n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    showCourseEnrollmentScreen();
                    break;
                case 2:
                    showAllEnrollments();
                    break;
                case 3:
                    showAllStudentsScreen();
                    break;
                case 4:
                    showAllCoursesScreen();
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
                Console.WriteLine("\n-----------------------------------Students-----------------------------------\n");
                Console.WriteLine("{0,-20}{1,-40}{2,-20}\n","ID","Name","Date of Birth");
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
                Console.WriteLine("\n------------------------------Enrollments------------------------------\n");
                Console.WriteLine("{0,-20}{1,-40}{2,-20}{3,-30}{4,-20}\n","Student ID","Student Name","Course ID","Course Name","Enrollment Date");
                foreach (Enroll e in en.listOfEnrollments())
                    info.display(e);
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public void showCourseEnrollmentScreen()
        {
            try
            {
                Console.WriteLine("\n-----Course Enrollment-----\n");
                Console.WriteLine("Enter the details to enroll for a course:\n");
                Console.WriteLine("Student ID:");
                string StudentId = Console.ReadLine();
                Console.WriteLine("Course ID:");
                string CourseId = Console.ReadLine();
                en.enroll(en.getStudentById(StudentId),en.getCourseById(CourseId));
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
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
                Console.WriteLine("\n-------------------------Student Details-------------------------\n");
                Console.WriteLine("{0,-20}{1,-40}{2,-20}\n", "ID", "Name", "Date of Birth");
                info.display(en.getStudentById(Id));
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
  

        public void showStudentRegistrationScreen()//Admin can admit student into university
        {
            try
            {
                Console.WriteLine("\n-----Student Admission-----\n");
                Console.WriteLine("Enter the student details to be added:\n");
                Console.WriteLine("Student ID:");
                string StudentId = Console.ReadLine();
                Console.WriteLine("Student Name:");
                string StudentName = Console.ReadLine();
                Console.WriteLine("Student DOB:");
                DateTime DOB = Convert.ToDateTime(Console.ReadLine());
                en.register(new Student(StudentId, StudentName, DOB));
            }

            catch (StudentException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }



        public void showAllCoursesScreen()//
        {
            try
            {
                Console.WriteLine("\n-----------------------------------Courses-----------------------------------\n");
                
                Console.WriteLine("{0,-20} {1,-30} {2,-20} {3,-15}\n","Course ID", "Course Name", "Duration", "Fees");
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
                Console.WriteLine("\n-----Add a new Course-----\n");
                Console.WriteLine("Enter the course details to be added:\n");
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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void showFirstScreen()//
        {
            
            Console.WriteLine("\n\n----------Welcome to Student Management System----------\n");
            Console.WriteLine("\nLogin as : \n\n1. Student\n2. Admin\n");
            try
            {
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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
