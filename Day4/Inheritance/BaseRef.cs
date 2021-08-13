using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class X
    {
        public int a;
        public X(int i)
        {
            a = i;
        }
    }
    class Y:X
    {
        public int b;
        public Y(int i):base(i)
        {
            b = i;
        }
    }
    class BaseRef
    {
        static void Main()
        {
            X x1 = new X(10);
        X x2;
        Y y1 = new Y(20);
        x2=x1; //Ok both are same type
        x2 = y1; //of Y is derived from X
        Console.WriteLine("x1.a: " + x1.a);
        Console.WriteLine("x2.a: " + x2.a);
        Console.Read();
    
        }
    }
}
