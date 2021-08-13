using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class Shape
    {
        public int _lenght;
        public int _width;
        public int _height;
       
    }
    class Ractangle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Rectangle= " + (_lenght * _width));
        }
    }
    class Square : Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Square= " + (_lenght *_lenght));
        }
    }
    class Triangle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Triangle= " + (0.5*_width * _height));
        }
    }
    class Test
    {
        static void Main()
        {
            Ractangle _rect = new Ractangle();
            _rect._lenght = 12;
            _rect._width = 13;
            _rect.Area();
            Square _square = new Square();
            _square._lenght = 12;
            _square.Area();
            Triangle _triangle = new Triangle();
            _triangle._height = 10;
            _triangle._width = 6;
            _triangle.Area();
            Console.Read();
        }
    }
}
