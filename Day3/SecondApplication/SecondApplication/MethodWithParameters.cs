using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class MethodWithParameters
    {
     
        void CallByValue(int Num1)
        { 
        
            Num1 = 200;
            Console.WriteLine("Inside the Method :{0}", Num1);
        }

        void CallByReference( ref int Num1)
        {
            Num1 = 300;
            Console.WriteLine("Inside the Method :{0}", Num1);
        }

        void Calculator(int Num1,out int Sum,out int Prod)
        {
            Sum = Num1 + Num1;
            Prod = Num1 * Num1;
        }
        static void Main()
        {
            int Val1 = 100;
            MethodWithParameters mobj = new MethodWithParameters();
            Console.WriteLine("CallByValue");
            Console.WriteLine("Before calling a Method :{0}", Val1);
            mobj.CallByValue(Val1);
            Console.WriteLine("After calling the Method:{0}", Val1);
            Console.WriteLine("-----------------------");
            Console.WriteLine("CallByReference");
            Console.WriteLine("Before calling a Method :{0}", Val1);
            mobj.CallByReference(ref Val1);
            Console.WriteLine("After calling the Method:{0}", Val1);
            Console.WriteLine("-----------------------");
            Console.WriteLine("With Out Parameter");
            int Total =0, Product=0;
            mobj.Calculator(Val1,out Total,out Product);

            Console.WriteLine("Sum is {0} && Product is{1}", Total, Product);

            Console.Read();
        }

    }
}
