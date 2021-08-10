using System;

namespace FirstApplication
{
    class First
    {
        //This is a program for explaining command line arguments
        static void Main()
        {
           
            string message = "dot net intro by Jamuna";
            Console.WriteLine("My first VS Application");
            Console.WriteLine(message);

          //int num1, num2;//declaring a variable
            int num1 = 5,num2 = int.MaxValue; //initializing a variable
            int num3=1;
            float num4 = 10.6f;
            num4 = num1;//implicit conversion
            num3 = (int)num4;//csharp is "strongly-typed" and must be "type casted" from different data types.
            num2 = int.MaxValue;
            Console.WriteLine("Num1 is "+num1+" Num2 is "+num2);
            Console.WriteLine(num3);
            //bool,byte,char,decimal(1.0 to 7.9*10 power 28),double,float,int,long,object,sbyte,short,string,struct,uint,ulong,ushort
            
            bool choice;
            choice = true;
         
           int result = Convert.ToInt32(choice);//explicit convertion
            choice = false;
            int result1 = choice ? 1 : 0;//ternary operator
            Console.WriteLine("Result is {0} and Result1 is {1}",result,result1);
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

           Console.ReadKey();
        }
    }
}
