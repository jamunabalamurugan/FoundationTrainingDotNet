using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class ParamArray
    {
        public float AddElements(params int[] marks)
        {
            float sum = 0;

            foreach (int i in marks)
            {
                sum += i;
            }
            
            float divresult=50f / 100f;
            Console.WriteLine("50/100 = {0}",divresult);
            return sum;
        }
    }
    class UseParamsArray
    {
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            float Total = app.AddElements(512, 720, 250, 567, 889,89,90,99,800);

            Console.WriteLine("The sum is: {0}", Total);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

