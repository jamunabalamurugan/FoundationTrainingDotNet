using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
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
    class Triangles : TwoDShape //,Shape   C# does not allow multiple inheritance
    {
        public string style; //style of triangle.
                             //return area of triangle.
        public double Area()//Method Overriding
        {
            return width * height / 2;
        }
        //display triange styles.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + style);
        }
    }

    class Triangle3D : Triangles//Multilevel Inheritance
    {
        public new double Area()//Method Overriding
        {
            // return (width * height / 2)+100;
            Console.WriteLine("Style is"+style);
            return base.Area()+100;

        }

    }
    class UseMultilevelInheritanace
    {
        static void Main()
        {
            Triangles t1 = new Triangles();
            t1.width = 4.0;
            t1.height = 4.0;
            t1.style = "Isosceles";
            Triangles t2 = new Triangles();
            t2.width = 8.0;
            t2.height = 12.0;
            //t2.style = "right";
            Console.WriteLine("Info of t1:");
            t1.ShowStyle();
            t1.showDim();
            Console.WriteLine("Area is : " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info of t2:");
            t2.ShowStyle();
            t2.showDim();
            Console.WriteLine("Area is : " + t2.Area());
            Triangle3D t3 = new Triangle3D();
            t3.style = "equilateral";
            Console.WriteLine("Area of 3D Traingle is "+t3.Area());
            t3.ShowStyle();
            Console.Read();

        }
    }
}
