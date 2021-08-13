using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class A1
    {
        public int i = 0;
    }
    class B1:A1
    {
        new int i;//this i hides the i in A
        public B1(int a, int b)
        {
            base.i = a; //i in A
            i = b;//i in B
        }
        public void Show()
        {
            Console.WriteLine("i in base class A: " + base.i);
            Console.WriteLine("i in derived class B: " + i);
        }
    }
    class NameHiding
    {
        static void Main()
        {
            B1 ob = new B1(2, 3);
            ob.Show();
        }
    }
}
