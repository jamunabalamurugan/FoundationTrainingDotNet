using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class DemoUsingOutMethod
    {
        public static void Main()
        {
            int total = 0;
            int Prod = 0;
            DemoUsingOutMethod obj = new DemoUsingOutMethod();
            obj.Calculate(10, 20, out total,out  Prod);
            //  Console.WriteLine("Sum = {0} and Product = {1}", total, Prod);
            Console.WriteLine("Sum = "+total+" Product = "+Prod);
            Console.ReadKey();
        }

        public bool Calculate(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
            return true;
        }
    }

    
}
