using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    

   public class AccessModifier
    {

        int a = 110;
        int b = 120;

        internal void InternalDisplay()
        {
            Console.WriteLine(" Internal Method a is {0} ", a);
        }
    }
   
}
