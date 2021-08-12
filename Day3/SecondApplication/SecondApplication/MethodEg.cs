using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class MethodEg
    {
        void Method1()
        {
            Console.WriteLine("Method with no arguments");
        }
        
      int Add(int val1,int val2)
        {
           // int Total= val1 + Val2; 
            return val1 + val2;
            
        }
        string Organization(string Name)
        {
            return Name;
        }
        
        static void Main()
        {
            MethodEg obj = new MethodEg();
            obj.Method1();
            int Total = obj.Add(10, 23);
            Console.WriteLine("Total :" + Total);
           Console.WriteLine("Organization Name {0}", obj.Organization("LTI"));
           
            Console.Read();
        }

    }
}
