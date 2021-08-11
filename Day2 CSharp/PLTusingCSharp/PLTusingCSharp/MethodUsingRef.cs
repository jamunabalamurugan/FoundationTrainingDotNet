using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class MethodUsingRef
    {
        public static void SimpleMethod(int j)
        {
            j =j+ 100;
        }

        public static void ReferenceMethod(ref int j)
        {
            j = j + 100;
        }

        public static void Main()
        {
            int i = 10;
            SimpleMethod(i);//Call by Value
            Console.WriteLine(i);

            ReferenceMethod(ref i);//call by reference
            Console.WriteLine(i);

            Console.ReadKey();

        }
    }


}
