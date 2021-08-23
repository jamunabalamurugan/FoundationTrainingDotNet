using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Eno = 71;//set prpoperty
            Console.WriteLine(e.Eno);//get property
            Console.Read();
        }
    }
}
