using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
    public class Student
    {
        public int rollno;
        public string name;
        public int age;
        public string phoneno;
        public override string ToString()
        {
            return rollno + "\t" + name + "\t" + age + "\t" + phoneno;
        }

    }
    class DelegateGreeting
    {
        public delegate void Greet(string str);//declaration of the delegate
        public delegate List<Student> Search(int num1);

        public static List<Student> allstudents = new List<Student> { new Student{rollno=1,name="Kavin",age=10,phoneno="123455" },
        new Student{rollno=2,name="Kanav",age=9,phoneno="123455" },
        new Student{rollno=3,name="Kayan",age=6,phoneno="123455" },
        new Student{rollno=3,name="Kala",age=16,phoneno="123455" },
        new Student{rollno=4,name="Krish",age=5,phoneno="123455" }};
        public static void GoodMorning(string name)
        {
            Console.WriteLine("Good Morning !!!"+name);
        }
        public static void GoodAfternoon(string name)
        {
            Console.WriteLine("Good Afternoon !!!" + name);
        }
        public static void GoodEvening(string name)
        {
            Console.WriteLine("Good Evening !!!" + name);
        }

        public void Hello()
        {
            Console.WriteLine("Hello!!!Welcome to CSharp Delegates");
        }
        public static List<Student> PrintAge(int age)
        {
            List<Student> students = (from s in allstudents
                                      where s.age == age
                                      select s).ToList(); 
            return students;
        }
        public static List<Student> PrintPhone(string phoneno)
        {
            List<Student> students = new List<Student>();
            return students;
        }
        public static List<Student>  PrintRollNo(int rollno)
        {
            //List<Student> students = (from s in allstudents
            //                          where s.rollno==rollno
            //                          select s).ToList();
            List<Student> students = new List<Student>();
            foreach (var item in allstudents)
            {
                if (item.rollno == rollno)
                    students.Add(item);

            }
            return students;
        }
        public static void Main()
        {
            Greet greet = new Greet(GoodAfternoon);//instantiating the delegate through its constructor
            greet("Kavin");

            greet = new Greet(GoodEvening);
            greet("Kanav");

            greet = new Greet(GoodMorning);
            greet("AuraTech");

            greet = new Greet(Console.Write);
            greet("Welcome to  Web Technologies ");
           
            greet("using .Net Framework");//calling the delegate 

            Search search = new Search(PrintAge);
            var result=search(10);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            search = new Search(PrintRollNo);
            result = search(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
