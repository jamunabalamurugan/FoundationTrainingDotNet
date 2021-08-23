using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student
    {

        string[] skills;
        string name, phone;
        int id;

        public Student()
        {
            skills = new string[3];
        }

        //example of use of "this"
        void SomeMethod(int id)
        {
            //Local variable takes priority
            if (this.id == id)
            {
                Console.WriteLine("Same person");
            }
        }

        //indexer- allows the object of the current class to be treated like an array(you can choose the array to expose)
        //this - an implicit reff to the current object
        public string this[int index]//accessSpecifier ReturnType this[dataType variable]
        {
            get { return skills[index]; }
            set { skills[index] = value; }
        }
        //public string[] Skills { get => skills; set => skills = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }

        public void GetStudentDetailsFromUser()
        {
            Console.WriteLine("Please enter the student ID");
            while (!Int32.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invaid ID please enter again");
            }
            Console.WriteLine("Please ente the student Name");
            name = Console.ReadLine();
            Console.WriteLine("Please ente the student Phone number");
            phone = Console.ReadLine();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student ID " + id);
            Console.WriteLine("Student Name " + name);
            Console.WriteLine("Student Phone " + phone);
            Console.WriteLine("The Student is skilled in ");
            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine("-------------------");
        }
        public override string ToString()//By giving virtual in the parent class i am giving permission to customise the way the method works with the child object
        {
            //return base.ToString();//base represents the object of the parent inside the child
            return "Student Id " + id + " Name " + name + " phone " + phone;
        }
    }
}
