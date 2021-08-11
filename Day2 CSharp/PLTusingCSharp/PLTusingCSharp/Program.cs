using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class Program
    {
        static void PrintTheGreatestOfTwo()//Header
        {
            int iNum1, iNum2;
            //iNum2 = 1000;
            //iNum1 = 200;
            Console.WriteLine("User please enter the first number");
           // iNum1 = int.Parse(Console.ReadLine());
            int temp;

            string var1 = Console.ReadLine();
            bool result = int.TryParse(var1, out iNum1);
            if (result == true)
                Console.WriteLine("The converted integer is s: {0}", iNum1);
            else
                Console.WriteLine("Could not convert iNum1 to an integer and iNum1 is {0}",iNum1);

            //if (int.TryParse(Console.ReadLine(), out iNum1))
            //    Console.WriteLine("The converted integer is s: {0}", iNum1);
            //else
            //    Console.WriteLine("Could not convert iNum1 to an integer");

            Console.WriteLine("Way to go... now please enter the Second number");
            iNum2 = int.Parse(Console.ReadLine());
            if (iNum1 == iNum2)
                Console.WriteLine("The numbers are equal");
            else if (iNum1 > iNum2)
                Console.WriteLine("Num1 is greater");
            else
                Console.WriteLine("Num2 is greater");
        }
        static void UnderstandingForLoop()
        {
            int i;
            //for(init;cond;upd)
            for ( i = 1; i <= 10; i++)   //i=i+14,i+=5,i+=j;
            {
                Console.WriteLine("i is {0}",i);
                PrintTheGreatestOfTwo();
                //Console.WriteLine("i is {0} ++i is  {1} & i++ is {2} ", i, ++i, i++);
            }
        }
        static void Main(string[] args)
        {
            int choice=0;
            bool status;
            do
            {
                status = false;
                Console.WriteLine("1.Print Greatest \t 2.Understanding For Loop \t 3.Print Prime Number \t0.Exit");
                while (!status)
                {
                    Console.Write("Please enter your choice");
                    //choice = int.Parse(Console.ReadLine());
                    status = int.TryParse(Console.ReadLine(), out choice);
                    if (!status)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                
                switch(choice)
                {
                    case 1:
                        PrintTheGreatestOfTwo();
                        break;
                    case 2:
                        UnderstandingForLoop();
                        break;
                    case 3:
                        int iMax;
                        Console.WriteLine("Please enter the maximum number");
                        status = int.TryParse(Console.ReadLine(), out iMax);
                        PrimeNumbers pn;//Creating an object
                        pn= new PrimeNumbers();// instantiate the object of a class
                        pn.ShowPrimeNumbers(iMax);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice...Only between 0 to 1");
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }
    }
}
