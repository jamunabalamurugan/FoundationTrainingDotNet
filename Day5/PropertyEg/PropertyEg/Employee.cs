using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class Employee
    {
        //private int EmpId;

        //public int Id
        //{
        //    get { return EmpId; }
        //    set { EmpId = value; }
        //}
        public int EmployeeId { get; set; }//This is called an auto implemented property
        public string Name
        {
            set
            {
                if (value == null) { Console.WriteLine("Invalid Name"); }

            }
        

        }
    }
    class UseEmployee
        {
            public static void Main()
            {
                Employee e1 = new Employee();
                e1.Name = "Jamuna";
               // string s1 = e1.Name;
                //Console.WriteLine(s1);
                Employee e2 = new Employee();
                e2.Name = null;
                Console.ReadKey();
            }
        }
    

}
