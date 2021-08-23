using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LateBindingEg
{

    //Dynamic Polymorphism refere to an entity changing its form depending on the circumstances.
    //A method is said to exhibit dynamic polymorphism when it exists in more than one form
    //The term late binding refers to resolution of its methods  at runtime instead of at compile time

    abstract class Shape
    {
        public int _lenght;
        public int _width;
        public int _height;

        public abstract void Area();
        public static void Hello()
        {
            Console.WriteLine("Hello from Shape Class");
        }

    }
    class Rectangle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle= " + (_lenght * _width));
        }
        public static void Hello()
        {
            Console.WriteLine("Hello from Rectangle");
        }
    }
    class  Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Square= " + (_lenght * _lenght));
        }
    }
    class Triangle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Area of Triangle= " + (0.5 * _width * _height));
        }
    }
    class Test
    {
         void  EarlyBindingDemo()
        {
            Rectangle _rect = new Rectangle();//The binding of the Area method to the object _rect is done at compile time...so its early binding
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

        }
         void LateBindingDemo()
        {
            Shape obj;
            Console.WriteLine("Enter the Shape to calculate Area \n 1.Rectangle\n 2. Square \n 3. Triangle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    obj = new Rectangle();//posponding the association of the method to its object to runtime is called late binding

                    break;
                case 2:
                    obj = new Square();

                    break;
                case 3:
                    obj = new Triangle();

                    break;
                case 0:
                    obj = null;
                    break;
                default:
                    obj = null;
                    break;
            }

            obj._lenght = 12;
            obj._height = 10;
            obj._width = 6;
            Console.WriteLine("Displaying the Area");
            obj.Area();
            Shape.Hello();
            Rectangle.Hello();
        }
        static void Main()
        {
            Test t = new Test();
            t.LateBindingDemo();
            Console.WriteLine(9f);
           // Console.WriteFloat(9f);

            Console.Read();
        }
    }

}
