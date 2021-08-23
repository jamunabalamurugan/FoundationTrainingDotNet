using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    class Program
    {
        void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("the ans is {0}", c);
        }
       
        static void Main(string[] args)
        {
            
            new Program().add(3,5);
            //m.add(5,2);
            Console.Read();

        }
    }
}
