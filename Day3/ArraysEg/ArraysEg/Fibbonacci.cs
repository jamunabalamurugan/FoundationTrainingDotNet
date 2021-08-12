using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            number1 = number2 = 1;
            int max = int.Parse(Console.ReadLine());
            if (max > 1)
            {
                Console.WriteLine(0);
                Console.WriteLine("{0}", number1);
            }
            else if(max==0)
            {
                return;
            }
            else  if(max==1)
            {
                Console.WriteLine(0);
                return;
            }
            while (number2 < max)
            {
                Console.WriteLine(number2);
                number2 += number1;
                number1 = number2 - number1;
            }
            Console.ReadLine();

        }
    }
}
