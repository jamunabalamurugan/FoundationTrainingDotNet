using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPSConcepts
{
    public abstract class Shape
    {
        protected string name;
        protected string colour;

        public Shape()
        {
            name = null;
            colour = null;
        }
        public Shape(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }
        //public virtual double Area()//Virtual and Abstract is used
        //                            //To postpond binding of this method during runtime
        //{
        //    return 0.0;
        //}
        public abstract double Area();
        public virtual void Accept()
        {
            Console.WriteLine("Pls enter Name and Colour");
            name = Console.ReadLine();
            colour = Console.ReadLine();
        }

    }
    public class Rectangle : Shape
    {
        protected int length;
        protected int breadth;

        public Rectangle(string name, string colour, int length, int breadth)
            : base(name, colour)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double Area()//Overriding the base class method
        {
            return length * breadth;
        }
        public void Draw()
        {
            Console.WriteLine("Drwaing Rectangle");
        }
    }
    public class Circle:Shape
        {
        protected double radius;
        protected const double PI = 3.14;
        public Circle()
        {
            radius = 1.0;
        }

        public Circle(string name,string colour,double radius)
            :base(name,colour)
        {
            this.radius = radius;
        }
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public override double Area()
        {
            return PI * radius * radius;
        }

    }

    class Program
    {
        static void Main()
        {
            Shape s;

            Console.WriteLine("Enter 1.Rectangle 2.Circle 0.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                s = new Rectangle("Rectangle","Pink",11,5);
                s.Accept();
                
            }
            else if(choice==2)
            {
                s = new Circle("Circle","Blue",3.5);
*                s.Accept();
            }
            else
            {
                //s = new Shape("None","Black");
                Console.WriteLine("Exiting...");
                Console.ReadKey();
                return;
            }

            double result = s.Area();
            Console.WriteLine("Area is {0}",result);
            Console.ReadKey();
        }
    }

}
