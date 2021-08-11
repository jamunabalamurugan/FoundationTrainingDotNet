using System;
using System.Collections.Generic;
using System.Text;


    class Duplicate
    {
        static void Main(string[] args)
        {
            char[] ch=new char[5]{'a','b','a','c','d'};

            int i,count=0;
            
	    Console.WriteLine("Enter a character:");
           

	    char input=Convert.ToChar(Console.ReadLine());
            

            for (i = 0; i <5;i++)
            {
                if (ch[i] ==input)
                {
                    count++;
                 
                }

            }
		Console.WriteLine("{0} appears {1} times in the character array",input, count);
                Console.ReadLine();
		
  	 }
      
    }


 
