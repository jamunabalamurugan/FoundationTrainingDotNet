using System;
using System.Collections.Generic;

namespace CollectionsandGenerics
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public Student(int Sid,string Sname)
        {
            this.Sid = Sid;
            this.Sname = Sname;
        }

    }
    class GenericList
    {
        static void Main()
        {
            //Student[] s = new Student[5]; //We can use List instead of Arrays as we do not have a fixed no of students in a batch
            List<string> lt = new List<string>();
            lt.Add("A");
            lt.Add("B");
            lt.Add("C");
            //lt.Add(10); --Error as the lt object can accept string data type only

            foreach(var item in lt)
            {
                Console.WriteLine(item);
            }

            List<Student> stu = new List<Student>();
            stu.Add(new Student (1001,"TOM" ));
            stu.Add(new Student(1002, "KIM"));

            // stu.Add(1002,"Kanav");-Error
            foreach (Student s in stu)
            {
                Console.WriteLine(s.Sid+" "+s.Sname );
            }

            Console.Read();
        }
    }
}
