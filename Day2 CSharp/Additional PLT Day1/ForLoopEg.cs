using System;
using System.Collections.Generic;
using System.Text;

namespace largest_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctr, nNum1, max=0;
            Console.WriteLine("Enter the numbers");
            for (ctr = 0; ctr <= 9; ctr++)
            {
                nNum1 = Convert.ToInt32(Console.ReadLine());
                if (nNum1 > max)
                {
                    max = nNum1;
                }

            }
            Console.WriteLine("The largest number is :" + max);
        }
    }
}
