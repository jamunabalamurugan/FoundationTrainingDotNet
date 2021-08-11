using System;

class Divisble_Check
{
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter two numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                if (num2 < num1)
                {
                    result = num1 / num2;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("A number cannot be divided by a number greater than itself");
                }
            }
            else
            {
                Console.WriteLine("A number cannot be divided by zero");
            }

        }
}
