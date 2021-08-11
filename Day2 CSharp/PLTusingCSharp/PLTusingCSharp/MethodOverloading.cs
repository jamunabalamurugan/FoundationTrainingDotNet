using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class MethodOverloading
    {
        static float fNum1=99.5f, fNum2=98.4f;
        static double total;
        //Methods have same name but are also having different signature
        //Method Signature will be varying based on the no of arguments,type and order in which it is passed
        static double  Add()
        {
            return fNum1 + fNum2;
        }
        static double  Add(double dNum1)
        {
            return total+dNum1;
        }
        static double Add(float i,float j)
        {
            if(i==0)
            {
                i = 95.3f;
            }
            return i + j;
        }
        static double Add(float i, int j)
        {
            if (i == 0)
            {
                i = 95.3f;
            }
            return i + j;
        }
        static int Add(int i,int j)
        {
            return i + j;
        }
        static float Add(float i)
        {
            return ++i;
        }

        //public static void Main()
        //{
        //    Console.WriteLine("main method without argument");
        //    MethodOverloading obj = new MethodOverloading();

        //    obj.Add();
        //    obj.Add(10.5f, 78.2f);
        //    obj.Add(10, 10);
        //    obj.Add(10f, 10);
        //    obj.Add(10);

        //}
        public static void Main(string[] args)
        {
            Console.WriteLine("Main method with string argument");
            MethodOverloading obj = new MethodOverloading();

            Add();
            Add(10.5f, 78.2f);
            Add(10, 10);
            Console.WriteLine(Add(10f, 10));
            Console.WriteLine(Add(10));
            Console.WriteLine();
            Console.ReadKey();
        }
    }


}
