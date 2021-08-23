using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{

    class PersonalDetails
    {
        string Name;
        int Age;
        string City;
        string State;
        public PersonalDetails()
        {
            Console.WriteLine("default constructor");
        }
        public PersonalDetails(string State)
        {
           this.State = State;
        }
      public PersonalDetails(string Name,int a,string c)
        {
           this.Name = Name;
            Age = a;
            City = c;
        }
     
      public  void displayPersonalInfo()
        {
            
            Console.WriteLine("Name {0} && Age {1} && City{2} ", Name, Age, City);
        }

        public void DisplayState()
        {
            Console.WriteLine(" state {0}", State);
        }

        //Destructors are methods with Class Name and prefix with ~(tilde)
        //Are called automatically when the memory is deallocated for an instance of that class
        //Garabge Collector calls the destructor when memory is deallocated
        //Destructors cannot be overloaded,pass parameters,cannot return values,cannot give access specifier
       ~ PersonalDetails()
        {
            Name = null;
            Age=0;
            City=null;
             State=null;
            Console.WriteLine("Destructor is called");
            
        }
              


    }
    class ConstructorProgram

    {
        static void Main()
        {
            PersonalDetails p = new PersonalDetails();
           PersonalDetails p1 = new PersonalDetails("Suman",23,"Pune");
            PersonalDetails p2 = new PersonalDetails("MAha");

            p1.displayPersonalInfo();
            p2.DisplayState();

            p1 = null;
            GC.Collect();

            Console.Read();
        }
    }
}
