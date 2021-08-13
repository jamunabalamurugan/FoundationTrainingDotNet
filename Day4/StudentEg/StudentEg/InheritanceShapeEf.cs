using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{
    class Shape
    {
        internal int _length;
        internal int _width;
        internal int _height;

    }
    class Ractangle : Shape
    {
        public void Area()
        {
            _length = 12;
            _width = 13;
            Console.WriteLine("Area of Rectangle= " + (_length * _width));
        }
    }
    class Square : Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Square= " + (_length * _length));
        }
    }
    class Triangle : Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Triangle= " + (0.5 * _width * _height));
        }
    }
    class Test
    {
        static void Main()
        {
            Ractangle _rect = new Ractangle();
            _rect._length = 12;
            _rect._width = 13;
            _rect.Area();
            Square _square = new Square();
            _square._length = 12;
            _square.Area();
            Triangle _triangle = new Triangle();
            _triangle._height = 10;
            _triangle._width = 6;
            _triangle.Area();
            Console.Read();
        }
    }
}
