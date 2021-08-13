using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class A
    {
        
        public A(string s)
        {
            Console.WriteLine("Welcome " + s);
        }
        

    }
    class B : A
    {
        public B()
            : base("David")
        {
            Console.WriteLine("Derived class Constructor");
        }
        public B(string s)
            : base(s)
        {
        }
        
    }
    class CustroctorInheritance
    {
        static void Main()
        {
           // B ob1 = new B();
            B ob2 = new B();
             //B ob3 = new B("Peter");
            Console.Read();
        }
    }
}
