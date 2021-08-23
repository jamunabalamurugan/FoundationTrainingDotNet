using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyEg;
using prjOOPSConcepts;
using System.IO;

namespace AssembleEg
{
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }


    class Program
    {
        void PrintFile()
            {
            
              string sFileContents = "";

              StreamReader oStreamReader = new StreamReader(File.OpenRead(@"e:\AT\Sample\Sample.txt"));
              sFileContents = oStreamReader.ReadToEnd();
                   
            string[] split = sFileContents.Split(':');
            oStreamReader.Close();
            foreach (var item in split)
            {
                Console.WriteLine(item);
            }
        }
        void PrintConsole()
        {
            Console.WriteLine("Enter address");
            string sContents = Console.ReadLine();
            string[] address = sContents.Split(',', (char)StringSplitOptions.None);
            foreach (var item in address)
            {
                Console.WriteLine(item);
            }

        }
        void PrintArea()
        {
            Console.WriteLine("Area is not assigned");

        }
        int PrintArea(int length)
        {
            // Console.WriteLine("The area is "+(length*length));
            return length * length;
        }
        void PrintArea(int length,bool status)
        {
            Console.WriteLine(length*length);
        }
        void PrintArea(int length,int breadth)
        {
            Console.WriteLine("The area is "+length*breadth);
        }
        void PrintArea(double l,double b)
        {
            Console.WriteLine("Length* Breadth"+ l*b);
        }
        static void Main(string[] args)
        {
            int a = 123;
            Int32 b = 123;
            long c = 1234;
            uint d = 5;
            char ch = 'A';
            ShoppingItem si1 = new ShoppingItem();
            Car c1 = new Car();
            Season s = Season.Autumn;
            Program p = new Program();
            p.PrintArea();//static polymorphism or Method Overloading or Static Binding
            p.PrintArea(6);
            p.PrintArea(6, 5);
            p.PrintArea(5.5, 7.8);
            //Method Overloading
            //The binding of the method with the object p is decided at the time of compilation itself

            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());

            p.PrintArea(num1, num1);//The c# compiler binds the PrintArea Method with 2  int parameters
            //with object p during compile time itself
            //p.PrintFile();
            p.PrintConsole();
            Complaints complaint = new Complaints();
            Console.WriteLine("Enter a valid Date");
            string str = Console.ReadLine();
            Console.WriteLine(complaint.convertToDate(str));
            Console.ReadKey();
        }
    }
}
