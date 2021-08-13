using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{
    class Student2
    {
        public int rollno;
        public int Rollno //auto
        {
            get; set; 
        }
        public string Name { get; set; }
        public string Course_joined { get; set; }
        public float Feepaid { get; set; }

        private float dueamount;
        public float DueAmount
        {
            get
            {
                return dueamount; //TotalFee - Feepaid; //DueAmount
            }
            set
            {
                if (value > 1000)
                    dueamount = value;
                else
                {
                    Console.WriteLine("Due Amout should be greater");
                    dueamount = 2000;
                }

            }
        }
        public float TotalFee
        {
            get
            {
                return Course_joined == "c#" ? 2000 : 3000;
            }
        }
        public Student2()
        {
            Console.WriteLine("Constructor Default");
        }

        public Student2(int rollno, string name, string course)
        {
            this.Rollno = rollno;
            this.Name = name;
            this.Course_joined = course.ToLower();
            this.dueamount = 500;
            //this.DueAmount = 1001;
            Console.WriteLine("Constructor Parameterized");
        }
        public Student2(int rollno)
        {

        }
        public void Payment(float amount)
        {
            Feepaid += amount;
        }

        public string Print()
        {
            return "Print Method"+"Roll no=" + Rollno + " Name=" + Name + " Course Joined=" + Course_joined + " Total Fee" + TotalFee + " Due Amount=" + DueAmount + " Fee paid=" + Feepaid;
        }
        //The ToString method of the Base Class Object will be called automatically whenever we use the instance in Console.WriteLine for eg.
        public override string ToString()
        {
            return "To String Method"+ "Roll no=" + Rollno + " Name=" + Name + " Course Joined=" + Course_joined + " Total Fee" + TotalFee + " Due Amount=" + DueAmount + " Fee paid=" + Feepaid;
        }
        //public override bool Equals(Object obj)
        //{
        //    //return base.Equals(obj);
        //    if (this==obj)
        //        return true;
        //    else
        //        return false;
        //}
    }

    class scenario2
    {
        static void Main()
        {
            Student2[] students = new Student2[2];
            Student2 student = new Student2(101,"Kavin","C#");//parameterized constructor is called
            Student2 s1 = new Student2();//default constructor is called
            s1.Print();
            Console.WriteLine(student);//Print the values returned by the ToString Method
            Console.WriteLine(new Student2(102,"Kanav","Java").Print());

            Student2 s2 = new Student2(101, "Kavin", "C#");
            student.Name = "Kavin Kumar";
            student.DueAmount = 500;
            //if(student==student2)//Its going to call the Equals Method automatically
            //{
            //    Console.WriteLine("The roll no already exists");
            //}
            int rollno;
            string name, course;
            float feepaid;
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Enter roll no.");
            //    rollno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter name.");
            //    name = Console.ReadLine();
            //    Console.WriteLine("Enter course joined");
            //    course = Console.ReadLine();
            //    Console.WriteLine("Enter Fee paid.");
            //    feepaid = Convert.ToSingle(Console.ReadLine());
            //    students[i] = new Student(rollno, name, course);
            //    students[i].Payment(feepaid);
            //    Console.WriteLine("");
            //}
            //for (int i = 0; i < students.Length; i++)
            //{
            //    // students[i].Print();
            //    Console.WriteLine(students[i]);// <Namespace>.<Class Name> -- StudentEg.Student
            //}
            Console.ReadKey();
        }
    }
}
