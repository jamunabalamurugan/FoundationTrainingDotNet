using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student
    {
        public int sid;
        public string name;
        public int age;
        public Student(int id,string nm,int ag)
        {
            sid = id;
            name = nm;
            age = ag;
        }
        public override string ToString()
        {
            return "Sid :" + sid + " Name: " + name + " Age : " + age;
        }
    }
    class ListEg
    {
       static void Main()
        {
            int t;
            ArrayList al = new ArrayList();//Collections  and it is not taking any datatype
            al.Add(10);
            al.Add(30.5f);
            int[] scores = new int[10];
            List<int> lt = new List<int>();//Generic and it is type specific
            List<float> lt1 = new List<float>();
            List<Student> students = new List<Student>();
            students.Add(new Student(101,"Kavin",10));
            students.Add(new Student(102, "Kanav", 5));
            students.Add(new Student(103, "Krish", 6));
            students.Add(new Student(104, "Kriya", 12));
            lt.Add(10);
            lt.Add(20);
            lt.Add(30);
            //lt.Add(30.5f);--Will not store any other data type

            Console.WriteLine("Count :{0}",lt.Count);

            foreach(var list in lt)
            {
                Console.WriteLine(list);
            }
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
        
       
    }
}
