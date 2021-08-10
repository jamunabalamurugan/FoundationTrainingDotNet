using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsstApplication
{
    class Second
    {
        static void DynamicCalculation()
        {
            int iNum1, iNum2;
            Console.WriteLine("User user please enter the first number");
            iNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Way to go... now please enter the first number");
            iNum2 = int.Parse(Console.ReadLine());
            string opr;
            Console.WriteLine("Please enter the symbol");
            opr = Console.ReadLine();
            switch (opr)
            {
                case "+":
                    int iSum = iNum1 + iNum2;
                    Console.WriteLine("The sum is " + iSum);
                    break;
                case "-":
                    int iSub = iNum1 - iNum2;
                    Console.WriteLine("The subraction result is " + iSub);
                    break;
                case "*":
                    int iProd = iNum1 * iNum2;
                    Console.WriteLine("The product is " + iProd);
                    break;
                case "/":
                    int iDiv = 0;
                    if (iNum2 != 0)
                    {
                        iDiv = iNum1 / iNum2;
                        Console.WriteLine("The division result " + iDiv);
                    }
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
        }
        //This functions calculates the total tax amount
        /// <summary>
        /// This functions calculates the total tax amount
        /// </summary>
        static void CalculateTotalAmount()
        {
            float amount = 0f, tax = 0f, netAmount = 0f;
            Console.WriteLine("Please enter the amount");
            amount = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the tax %");
            tax = float.Parse(Console.ReadLine());
            netAmount = amount + (amount * tax / 100);
            //Console.WriteLine("The net amount is " + netAmount);

            Console.WriteLine("The bill amount {3} net amount is {0} and Tax Amount is {1}  tax% is {2} tax is high? {4}",netAmount,(amount*tax/100),tax,amount,tax>10?true:false);

            Console.WriteLine();

        }
        //Created on 10th August 2021 by Jamuna to learn csharp 4.00pm
        /// <summary>
        /// This method will take a number as input and check if it is a prime number or not
        /// </summary>
        /// <param name="num"></param>
        /// <returns>it return a true if its a prime number otherwise returns a false</returns>
        static bool FindPrimeOrNot(int num)
        {
            bool bResult = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    bResult = false;
                    break;
                }
            }
            return bResult;
        }
        static void TakeNumberAndCheckForPrime()
        {
            int iNum = 0;
            Console.WriteLine("Please enter the number");
            iNum = int.Parse(Console.ReadLine());
            bool result = FindPrimeOrNot(iNum);
           // if(FindPrimeOrNot(iNum))
           if(result)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("Not a prime number");

            if (!result)
            {
                Console.WriteLine("Please enter a valid prime number");
            }
        }
        static void Main(string[] args)
        {

            //TakeNumberAndCheckForPrime();
            //CalculateTotalAmount();
            //DynamicCalculation();
            int iChoice;
            do
            {
                Console.WriteLine("Please enter your choice \n 1. Check Prime \t2.Calculate Tax \t3.Dynamic Calculation\t 0.Exit\n");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        TakeNumberAndCheckForPrime();
                        break;
                    case 2:
                        CalculateTotalAmount();
                        break;
                    case 3:
                        DynamicCalculation();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            } while (iChoice != 0);
            Console.ReadKey();
        }
    }
}
