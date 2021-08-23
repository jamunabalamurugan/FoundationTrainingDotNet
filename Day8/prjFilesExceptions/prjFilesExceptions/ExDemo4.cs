using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithExceptionHandling
{
    class ExceptionDemo4
    {
        public static void GetException()
        {
            float i, j;
            Console.WriteLine("Enter i,j values");
            i = float.Parse(Console.ReadLine());
            j = float.Parse(Console.ReadLine());
            try
            {
                if (j == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    Console.WriteLine("Divison of {0}/{1}={2}", i, j, i / j);
                }
		int a=0,b=0,c=0;
		Random r=new Random();
		for(int i=0;i<32000;i++)
		{
			try{
				b=r.Next();
				c=r.Next();
				a=12345/(b/c);
			}
			catch(DivideByZeoException e)
			{
				a=100;
				Console.WriteLine("Random no raised an error"+e.Message);
			}
			catch(ArithmeticException e)
			{
				a=0;
				Console.WriteLine(e.Message);
			}
			Console.Writeline("a : "+a);
		}

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("J value can not be Zero");
                Console.WriteLine("Message= " + ex.Message);
                Console.WriteLine("Stack Trace= " + ex.StackTrace);
                Console.WriteLine("TargateSite= " + ex.TargetSite);
                Console.WriteLine("Source= " + ex.Source);
            }

	    
            
        }
        static void Main()
        {
            ExceptionDemo4.GetException();
            Console.Read();

        }
    }
}
