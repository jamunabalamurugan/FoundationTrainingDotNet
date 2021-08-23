using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class StudentEg
    {
        public int Mark, Rollno;
        public string Name;
        public StudentEg(string Name, int Mark, int Rollno)
        {
            this.Name = Name;
            this.Mark = Mark;
            this.Rollno = Rollno;
        }
    }
    class UseStudent
    {
        static void Main()
        {
            // adding elements+
            StudentEg[] studs = new StudentEg[10];
            List<StudentEg> students = new List<StudentEg>() {

            new StudentEg("Jay",80,1),

            new StudentEg("Sandy",70,2),

            new StudentEg("Abi",60,3),

            new StudentEg("Vinay",50,4),

            new StudentEg("Divya",40,5)

            };

            StudentEg obj = new StudentEg("Kavin", 99, 10);
            students.Add(obj);

            // accessing element 

            foreach (var student in students)

            {

                Console.Write(student.Name);

                Console.Write("\t\t" + student.Rollno);

                Console.WriteLine("\t\t" + student.Mark);

            }

            Console.Read();
        }
    }
}

