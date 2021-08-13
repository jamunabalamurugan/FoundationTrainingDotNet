using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkwithInheritance
{
    class Room
    {
        private int _length;
        protected int _width;
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public int  Area()
        {
            return (_length * _width);
        }

    }
    class Guest_Room : Room
    {
        public void Accept()
        {
            Console.WriteLine("Enter Length:");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            _width = int.Parse(Console.ReadLine());
        }
    }
    class Hall:Guest_Room
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Create object of Derived class and instance of 
             * derived class can access the members of base and 
             * derived class */
            Guest_Room _guestroom = new Guest_Room();
           
            _guestroom.Accept();
            Console.WriteLine("Area of Guest Room " + _guestroom.Area());
            /*Create object of Base class and instance of 
             * Base class can access the members of base only */
            Room _room = new Room();
            Console.WriteLine("Area of Virtual Room " + _room.Area());
            /*Create object of base class and instance of 
             * Derived class can access the members of base only
              */
            Room _room1 = new Guest_Room();
           
            Console.WriteLine("Area= " + _room1.Area());

            Hall _hall = new Hall();
            _hall.Accept();
            Console.WriteLine("Area of the Hall = " + _hall.Area());

            Console.Read();

            
        }
    }
}
