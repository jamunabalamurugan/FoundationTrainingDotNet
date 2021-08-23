using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    class EmployeeInfo
    {
        private string Name;
        private int Eid;
        private string Phno;
        private int salary = 20;
        internal int a;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name,Eid,Phone,Salary");
            Name = Console.ReadLine();
            Eid = Convert.ToInt32(Console.ReadLine());
            Phno = Console.ReadLine();
            salary = Convert.ToInt32(Console.ReadLine());

        }
        public void displayDetails()
        {
          
            Console.WriteLine("Id {0} && Name {1}" +
                " && Phoneno {2}", Eid, Name, Phno);
        }
       public void DisplaySalary()
        {
            Console.WriteLine("Salary is {0}",salary);
        }
      
    }


    class EmployeeProgram
    {
        static void Main()
        {
            EmployeeInfo emp = new EmployeeInfo();
            //emp.Eid = 1001;
            //emp.Name = "ABI";
            //emp.Phno = "9958631470";
            //emp.salary = 50000;
            emp.AcceptDetails();
            //emp.salary = 9000; //Error due to salary being private member variable
            emp.a = 21;
            emp.displayDetails();
            Console.WriteLine("Salary of emp EmployeeInfoObject");
            emp.DisplaySalary();

            Console.WriteLine("Salary of Anonymous EmployeeInfoObject");

            new EmployeeInfo().DisplaySalary();
            new EmployeeInfo().DisplaySalary();
            Console.Read();

        }

    }
}
