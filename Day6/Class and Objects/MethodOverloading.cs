using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    class Shape
    {
        int length;
        int breadth;
        public Shape()//Constructor is a function with the same name of the class
        {
            length = 5;
            breadth = 10;
            Console.WriteLine("Default Constructor Called");
        }
        public Shape(int l,int b)//Constructor overloaded
        {
            length = l;
            breadth = b;
            Console.WriteLine("Overloaded Constructor is called");
        }
        ~Shape()
        {
            length = 0;
            breadth = 0;
            Console.WriteLine("Destructor is called");
        }
        public int Area()
        {
            return length * breadth;
        }
      public  int Area(int a)
        {
            this.length = a;
            Console.WriteLine("Length is {0}",length);
            Console.WriteLine("breadth is {0}",breadth);
            return length * length;
        }
       public  int Area(int l, int b)
        {
            length = l;
            breadth = b;
            return length * breadth;
        }
    }

    class MethodOverloading
    {
        static void Main()
        {
            //get the input from tne user
            Shape s = new Shape();//Calling the default Constructor
            int i = s.Area(10);
            Console.WriteLine( "Square {0}",i);
            Console.WriteLine("Rectangle {0}", s.Area(10,20));

            Console.WriteLine("After Constructor{0}", new Shape().Area());
            s = new Shape(50, 60);//Call the overloaded constructor
            
            Console.WriteLine("Rectangle {0}", s.Area());
            s = null;
            GC.Collect(); //Calling the Garbage Collector which inturn will invoke the Destructor
            Console.WriteLine("Square {0}", new Shape(20,30).Area());
            Console.WriteLine("Rectangle {0}",new Shape(40,50).Area());


            Console.ReadKey();
        }
    }
}
