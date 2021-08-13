using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class TwoDShape
    {
        public double width;
        public double height;
        public void showDim()
        {
            Console.WriteLine("width and height are {0} and {1}", width, height);
        }
    }
    class Triangles : TwoDShape
    {
        public string sytle; //style of triangle.
       //return area of triangle.
        public double Area()
        {
            return width * height / 2;
        }
        //display triange styles.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + sytle);
        }
    }
    class rectangle : TwoDShape
    {
        public double Area()
        {
            return width * height;
        }
    }
    class Shapes
    {
        static void Main()
        {
            Triangles t1 = new Triangles();
            t1.width = 4.0;
            t1.height = 4.0;
            t1.sytle = "Isosceles";
            Triangles t2 = new Triangles();
            t2.width = 8.0;
            t2.height = 12.0;
            t2.sytle = "right";
            Console.WriteLine("Info of t1:");
            t1.ShowStyle();
            t1.showDim();
            Console.WriteLine("Area is : " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info of t2:");
            t2.ShowStyle();
            t2.showDim();
            Console.WriteLine("Area is : " + t2.Area());
            Console.Read();

        }
    }
}
