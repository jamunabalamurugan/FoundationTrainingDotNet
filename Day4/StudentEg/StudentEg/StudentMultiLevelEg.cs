using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{
    class Student
    {
        private string Rollno;
        private string Name;
        private string Class;
        public void GetData()
        {
            Console.WriteLine("Enter Rollno");
            Rollno = Console.ReadLine();
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class");
            Class = Console.ReadLine();
        }
        public void PutData()
        {
            Console.WriteLine("Name of the Student= " + Name);
            Console.WriteLine("RollNo= " + Rollno);
            Console.WriteLine("Class= " + Class);
        }
    }
    class Marks : Student
    {
        protected int[] a = new int[5];
        public void GetMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter Subject{0} Marks:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Marks in  Subject{0} {1} ", i + 1, a[i]);

            }
        }
    }
    class Result : Marks
    {
        int TotMarks = 0;
        public void GetResult()
        {

            for (int i = 0; i < a.Length; i++)
            {
                TotMarks = TotMarks + a[i];
            }

        }
        public void DisplayResult()
        {
            Console.WriteLine("====== Result ========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks= " + TotMarks);
        }
    }
    class MultiLevel
    {
        static void Main()
        {
            Result or = new Result();
            or.GetData();
            or.GetMarks();
            or.GetResult();
            or.DisplayResult();
            Console.ReadLine();

        }
    }
}
