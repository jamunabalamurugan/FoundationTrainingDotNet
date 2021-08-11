using System;

    public class Number
{
	static int Number1,Number2,Number3;
	
	public static void Greater()
	{
		if(Number1 > Number2 && Number1 > Number3)
		{
			Console.WriteLine("First number is the greatest: {0}",Number1);
		}
		else if(Number2 > Number1 && Number2 > Number3)
		{
			Console.WriteLine("Second number is the greatest: {0}",Number2);	
		}
		else
		{
			Console.WriteLine("Third number is the greatest: {0}",Number3);
		}
	}
	
	static void Main(string[] args)
	{
		
		Console.WriteLine("Enter the first number");
		Number1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number");
        Number2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the third number");
        Number3 = Convert.ToInt32(Console.ReadLine());

		Greater();
		Console.ReadLine();
	}
}
        