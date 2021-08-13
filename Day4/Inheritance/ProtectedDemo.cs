using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class BB
    {
        protected int i, j;//private to B,but accessable by D
        public void set(int a, int b)
        {
            i = a;
            j = b;
        }
        public void show()
        {
            Console.WriteLine("i={0} and j={1}",i,j);
        }
    }
    class D:BB
    {
        int k;//private
        public void setk()
        {
            k = i * j;
        }
        public void showk()
        {
            Console.WriteLine("k= " + k);
        }
    }
    class ProtectedDemo
    {
        static void Main()
        {
            D ob = new D();
            ob.set(2, 3);
            ob.show();
            ob.setk();
            ob.showk();
            Console.Read();
        }
    }
}
