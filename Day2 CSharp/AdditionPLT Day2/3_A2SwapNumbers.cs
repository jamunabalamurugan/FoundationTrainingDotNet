using System;
public class SwapNumber
{
    void SwapNum(ref int a, ref int b)
    {
        int temp;
        temp = a;
        a = b;
        b = temp;

    }
    static void Main(string[] args)
    {
        SwapNumber classobj = new SwapNumber();
        int Number1, Number2;
        Console.WriteLine("Enter the first number");

        Number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number");

        Number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The value of first number is {0}",
        Number1);
        Console.WriteLine("The value of second number is {0}",
        Number2);
       
        classobj.SwapNum(ref Number1,ref Number2);
              
        Console.WriteLine("Now the value of first number after swaping is {0}", Number1);
        Console.WriteLine("Now the value of second number after swapping is {0}", Number2);
    }
}
