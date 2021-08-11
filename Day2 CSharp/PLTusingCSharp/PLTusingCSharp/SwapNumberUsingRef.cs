using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    public class SwapNumber
    {
        void SwapNum( ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;

        }
        static void Main(string[] args)
        {
            SwapNumber snobj = new SwapNumber();
            int Number1, Number2;
            Console.WriteLine("Enter the first number");

            Number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The value of first number is {0}",
            Number1);
            Console.WriteLine("The value of second number is {0}",
            Number2);

            snobj.SwapNum( ref Number1, ref Number2);

            Console.WriteLine("Now the value of first number after swaping is {0}", Number1);
            Console.WriteLine("Now the value of second number after swapping is {0}", Number2);
            Console.ReadKey();
        }
    }
}
