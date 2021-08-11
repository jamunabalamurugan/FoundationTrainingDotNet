using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class PrimeNumbers
    {
        public void ShowPrimeNumbers(int Num)
        {
            Boolean isPrime = true;
            Console.WriteLine("\nThe prime numbers between 1-{0} is:", Num);

            for (int i = 0; i < Num; i++)
            {
                for (int j = 2; j < Num; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    if (i != 1)
                        Console.WriteLine("{0}", i);
                }
                isPrime = true;
            }

        }
    }


    class UsePrime
    {
        static void Hello()
        {
            Console.WriteLine("Welcome to Classes and Objects");
        }
        static void Main()
        {
            Hello();//static method that belongs to the same class
            //if you have to call a method that belongs to another class then we need a object of the class
            PrimeNumbers pnobj = new PrimeNumbers();//create and object and initialise
            pnobj.ShowPrimeNumbers(25);
            Console.ReadKey();
        }
    }

}
