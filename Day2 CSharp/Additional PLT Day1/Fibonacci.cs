using System;
class Fibonacci
    {
        static void Main(string[] args)
        {       
            int number1;
            int number2;
            number1=number2=1;
            Console.WriteLine("{0}", number1);
        while (number2 < 200)
        {
            Console.WriteLine(number2);
            number2 += number1;
            number1 = number2-number1;
        }
Console.ReadLine();

        }
}
