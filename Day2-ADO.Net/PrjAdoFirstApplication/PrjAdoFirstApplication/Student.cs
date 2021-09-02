using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjAdoFirstApplication
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student()
        {

        }
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public void TakeStudentDataFromUser()
        {
            Console.WriteLine("Please enter the Student name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the student age");
            int age;
            Int32.TryParse(Console.ReadLine(), out age);
            Age = age;
        }
        public override string ToString()
        {
            return "ID is " + Id + " Name is " + Name + " Age is " + Age;
        }
    }
}
