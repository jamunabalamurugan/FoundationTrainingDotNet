using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
    class CallByRefEg
    {
        static void Main()
        {
            int i = 5,j=4;  //i is created in Main() i has the address H100
           // SimpleMethod(i);//call by value...you are passing the value which is 5 here

            Console.WriteLine("The value of i is : "+i);

            SimpleMethod(ref i);//Call by reference...you are passing the address of i which is H100 here

            Console.WriteLine("The value of i is : " + i);
            Console.WriteLine("The Calulate function result is : "+Calculate(i, j));

            int sum=0, product=0;
            Calculate(i, j, out sum, out product);
            Console.WriteLine("Sum is : {0} and Product is {1}",sum,product);
            Console.ReadKey();
        }
     
        public static void SimpleMethod(ref int x)//x is created in SimpleMethod() with the address of i ...x will point to H100
        {
            x=x+100;
            Console.WriteLine("x is : "+x);

        }
        static int Calculate(int i,int j)
        {
            if(i<j)
            return i + j;
            else
            return i * j;
        }
        //Output parameter out type (when we need more return values than one)
        static int Calculate(int a,int b,out int sum,out int product)
        {
             sum = a + b;
             product = a * b;
             return 0;
        }


    }

}
