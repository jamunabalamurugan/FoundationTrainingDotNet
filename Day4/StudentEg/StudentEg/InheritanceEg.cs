using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{
    class Vehicle
    {
        protected int vehicleid;
        protected string name;
        public double price;

        protected Vehicle()
        {
            vehicleid = 0;
            name = null;
            price = 0;
            Console.WriteLine("Base class Vehicle Default Constructor called");
        }
        protected Vehicle(int vehicleid,string name)//Parametrized Baed Class Constructor
        {
            this.vehicleid = vehicleid;
            this.name = name;
            Console.WriteLine("Base Class  Vehicle Overloaded constructor called");
        }

    }
    class Car : Vehicle
    {
        internal int speed;
        internal int noofseats;
        internal string type;

        public Car()
        {
            Console.WriteLine("Car Constructor is called");
        }

        public Car(int vehicleid,string name,int speed,int noofseats,string type):base(vehicleid,name)//Calling the Vehicle class Overloaded Constructor using base keyword
        {
            this.speed = speed;
            this.noofseats = noofseats;
            this.type = type;
            Console.WriteLine("Parameterized constructor called");
        }

        public void PrintCar()
        {
            Console.WriteLine("Car No:{0}\t Car Name:{1}\t Speed :{2} \t Price {3}",vehicleid,name,speed,price);
        }
    }

    class UseCar
    {
        public static void Main()
        {
            Car carobj = new Car();//default constructor called

            Car c1 = new Car(5,"Swift",100, 6, "Sedan");

            Console.WriteLine("Speed of carobj is {0}", carobj.speed);
            Console.WriteLine("Speed is c1 {0}",c1.speed);

            c1.PrintCar();
            Console.ReadKey();
        }
    }
}
