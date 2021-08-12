using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class DynamicVarEg
    {
        static int Add(int a,int b)
        {
            return a + b;
        }
        static float Add(float a,float b)
        {
            return a + b;
        }
        public static void Main()
        {
            var studentid = 11;//The data type is assigned according to the value assigned at the time of declarion itself
            var studentname = "Kavin";
            var dob = "06/01/2011";
            var marks = 99.6;
            var age = 23f;
            //age = "twenty three"; The var datatype cannot be changed....only value can changed
            studentid = 45;
            var aggregatemarks = 89.45d;
            
            dynamic city;//it is not type specific

            city = "Chennai";
            city = 1;
            city = 34.4f;
            var result = Add(12, 15);//it is type specific
            var result1 = Add(12.3f, 15.1f);

            Console.WriteLine(result+","+result1);
            Console.ReadKey();
        }
    }
}
