using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class ArrayofObjectEx
    {
        int id;
        string Name;
        int salary;

        public ArrayofObjectEx(int id, string Name, int salary)
        {
            this.id = id;
            this.Name = Name;
            this.salary = salary;
        }

        public void DisplayEmpdetails()
        {
            Console.WriteLine(" id {0} && Name {1} &&  salary{2} ", id, Name, salary);
        }

        ~ArrayofObjectEx() 
        {
            Console.WriteLine(" Destructor is called");
        }
        static void Main()
        {
            int i, s;
            string n;

            ArrayofObjectEx[] aobj = new ArrayofObjectEx[2];

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Enter the ID Name and Salary");
                i = Convert.ToInt32(Console.ReadLine());
                n = Console.ReadLine();
                s = Convert.ToInt32(Console.ReadLine());
                aobj[j] = new ArrayofObjectEx(i, n, s);

            }
            /*aobj[0] = new ArrayofObjectEx(10, "Sunil", 20000);
            aobj[1] = new ArrayofObjectEx(11, "Vanitha", 30000);*/

            for (int k = 0; k < 2; k++)
            {
                aobj[k].DisplayEmpdetails();
            }

            Console.Read();
        }
    }
}
