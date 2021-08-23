using prjOOPSConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOPSConcepts
{
    class House
    {
        public string name;
        internal int age;
        private int marks;
        protected string location;
    }

}
class Program
{
    static void Main(string[] args)
    {
        House house = new House();
        house.name = "DLF";
        house.age = 20;
        // house.marks = 99; //We cannot access private variables
        //  house.location = "Chennai"; //We cannot access protected variables 

        Console.WriteLine("You are living in {0} and your age is {1}",house.name,house.age );
        Console.ReadKey();
    }
}
