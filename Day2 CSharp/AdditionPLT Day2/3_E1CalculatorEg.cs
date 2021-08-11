using System;


class Program
{
    static int res;
    public static void addition(int a, int b)
    {
        res = a + b;
        Console.WriteLine("The sum of the two numbers entered is {0}", res);

    }
    public static void subtraction(int a, int b)
    {
        res = a - b;
        Console.WriteLine("The difference of the two numbers entered is {0}", res);
    }
    public static void multiplication(int a, int b)
    {
        res = a * b;

        Console.WriteLine("The product of the two numbers entered is {0}", res);
    }
    public static void division(int a, int b)
    {
	if(b==0)
	{
        Console.WriteLine("You cannot divide by 0");
	}
	else
	{
	res = a / b;

        Console.WriteLine("The division of the two numbers entered gives {0}", res);
	}
    }
    static void Main(string[] args)
    {
        int Num1, Num2, ch;

        string str1, str2, str3;
        Console.WriteLine("Enter the first number:");
        str1 = Console.ReadLine();
        Num1 = Convert.ToInt32(str1);

        Console.WriteLine("Enter the second number:");
        str2 = Console.ReadLine();
        Num2 = Convert.ToInt32(str2);

        Console.WriteLine("Main Menu");
        Console.WriteLine("1.Addition");
        Console.WriteLine("2.Subtraction");
        Console.WriteLine("3.Multiplication");
	Console.WriteLine("4.Division");
        Console.WriteLine("Enter the Operation you want to perform");
        str3 = Console.ReadLine();
        ch = Convert.ToInt32(str3);

        switch (ch)
        {
            case 1:
                addition(Num1, Num2);
                break;
            case 2:
                subtraction(Num1, Num2);
                break;
            case 3:
                multiplication(Num1, Num2);
                break;
            case 4:
                division(Num1, Num2);
                break;

        }


        Console.ReadLine();

    }


}