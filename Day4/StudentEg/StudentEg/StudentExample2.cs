using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }
        protected string address;
        internal int age;
        protected internal string phone;


        public Student1()
        {
            Console.WriteLine("Default Student1 Constructor Called");
        }

        public Student1(int id, string name, DateTime dateofbirth)
        {
            this.Id = id;
            this.Name = name;
            this.Dateofbirth = dateofbirth;
            Console.WriteLine("Parameterized Student1 Constructor called");
        }
    }

    class StudentInfo
    {
        //Student1 s = new Student1();//Container Relationship
        Student1[] students = new Student1[21];
        
        public StudentInfo()
        {
            //s.Id = 100;
            //s.Name = null;
            //s.Dateofbirth = Convert.ToDateTime("1998-07-31");
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student1();
            }
            Console.WriteLine("Default Student Info Constructor called");
        }
        public void AddStudent(Student1 s,int count)
        {
            students[count] = s;
        }
        public void display(Student1 student)
        {
            Console.WriteLine("ID=" + student.Id + " Name=" + student.Name + " Date of birth=" + student.Dateofbirth);
            Console.ReadKey();
        }

        public void display()
        {
            foreach (var s in students)
            {
                Console.WriteLine("ID=" + s.Id + " Name=" + s.Name + " Date of birth=" + s.Dateofbirth);
            }
            
            Console.ReadKey();
        }
    }

    class App
    {
        static void Main()
        {

            Student1 stud1 = new Student1(1, "Kavin", Convert.ToDateTime("1998-07-31"));//Student COnstructor Para
            //  or DateTime.ParseExact("1998-07-27", "yyyy-MM-dd", null) 
            Student1 stud2 = new Student1(2, "Kanav", DateTime.ParseExact("1997-12-31", "yyyy-MM-dd", null));
            DateTime dt2 = new DateTime(2015, 12, 31);
            Student1 stud3 = new Student1(1, "Sumedha", dt2);
            
            StudentInfo info = new StudentInfo();//Student1 default constructor and then StudentInfo Default Constructor
            info.AddStudent(stud1,0);
            info.AddStudent(stud2, 1);
            info.AddStudent(stud3, 2);
            info.display();

            //info.display(stud1);
            //info.display(stud2);
            //info.display(stud3);
        }
    }
}
