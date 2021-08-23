using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessor
{

    class Employee
    {
       //Properties or extension mof Attributes
        //A property is usually declared Private in a class
        //A pair of set and get accessor method will access to the property
        //Properties can have any program logic,throw exceptions,be overriden

        //Syntax for declaring a property
        //<access_modifier>  <return_type> <property_name>{get{} set{}}
        //A property generally has a private data member accompanied by accessor functions and is accessed as a field of a class
        int x;

        public int Age { get { return x; } set { x = value; } }//value is a variable present by default in the set accessor

        int _Eid;
        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }
       public string Ename { get; set; } //auto 
        public string City;

//Below is normal getter setter from previous VS:
//private string _Ename;
//public string EName
//        {
//            get { return _Ename; }
//            set { _Ename = value; }
//        }
//        This is the new getter setter:

//public string EName { get => _Ename; set => _Ename = value; }



        public  Employee(int Eid,string Ename,string City)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.City = City;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Kavin","Bangalore");
            Console.WriteLine(e.Eid);
           // e._Eid = 1001;--Error as they are private by default
           // e.x = 10;--Error
            e.Eid = 1001;
            e.Ename = "sdfgh";
            Console.WriteLine(e.Eid);
            Console.WriteLine(e.Ename);


            e.Age = 10;//calling the set method
            int y = e.Age;//get method is called
            Console.WriteLine(y);  //Displays 10

            Console.ReadKey();
        }
    }
}
