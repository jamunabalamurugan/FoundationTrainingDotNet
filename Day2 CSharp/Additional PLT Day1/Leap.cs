using System;
using System.Collections.Generic;
using System.Text;

namespace Leap
{
    class Program
    {
        static void Main(string[] args)
        {
            int nYear;
            Console.WriteLine("Please enter the year");
            nYear = Convert.ToInt32(Console.ReadLine());
            if(nYear%400 ==0 || (nYear%100 != 0 && nYear%4 == 0))

            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
