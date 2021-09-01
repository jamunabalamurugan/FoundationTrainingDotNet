using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day13Project
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Fees { get; set; }

        public Course()
        {
            this.Name = null;
            this.Fees = null;
        }
        public Course(string Name)
        {
            this.Name = Name;
            this.Fees = null;
        }
        public Course(string Name,float? Fees)
        {
            this.Name = Name;
            this.Fees = Fees;
        }
        public void TakeCourseDataFromUser()
        {
            Console.WriteLine("Please enter the course name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the fee amount");
            Fees = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Id: " + Id + "Name :" + Name + " Course Fees " + Fees;
        }
    }
}
