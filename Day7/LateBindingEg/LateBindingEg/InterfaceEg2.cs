using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEg2
{
    interface IArea
    {
        
        void calcArea(double Radius);//Looks like a class but has no implementation
        //contains only declaration of members
        //standard structure of methods
        //define what a class can do,does not define how the class does it

        //class can inherit multiple interfaces


    }

    interface IVolume
    {
        void calcVolume(int Side);

    }

    public class Cube : IArea, IVolume
    {
        public void calcArea(double Radius)
        {
            double Pie = 3.14;
            double Result;
            Result = Pie * Radius * Radius;
            Console.WriteLine("The Area of the circle is: {0}", Result);


        }
        public void calcVolume(int Side)
        {
            int Result;
            Result = Side * Side * Side;
            Console.WriteLine("The Volume of the cube is: {0}", Result);
        }

    }
    class class1
    {
        public static void Main(string[] args)
        {
            Cube obj = new Cube();
            double Radius;
            int Side;

            Console.WriteLine("Enter the radius of a circle");
            Radius = Convert.ToDouble(Console.ReadLine());
            obj.calcArea(Radius);

            Console.WriteLine("Enter the side of a cube");
            Side = Convert.ToInt32(Console.ReadLine());
            obj.calcVolume(Side);


            Console.ReadLine();

        }

    }

}
