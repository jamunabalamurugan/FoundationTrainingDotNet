using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class User
    {
        private string name;//Variable
        private string location;
        public string City//
        {
            set { if (value == "") Console.WriteLine("Sorry City cannot be Empty"); }
        } //auto and Its is write only ....cant read as we dont have a get
        public User(string a, string b)
        {
            name = a;
            location = b;
        }
        public string Name//Property for accesing the private variable name
        {
            get { return name.ToUpper(); }//Here the get method is also used for computing and return the value
            set//before assigning a value to the private variable the validity can be ensured
            {
                if (value.Length > 5)
                    name = value;
                else
                    Console.WriteLine("User Name should have minimum 5 letters");
            }
        }
        public string Location { get { return location; } }//Read only property needs onlt get accessor
    }
    class UserProgram
    {
        static void Main(string[] args)
        {
            User u = new User("Jamuna Balamurugan", "Chennai");
            Console.WriteLine("Welcome {0}! Please enter the changes you need in your Name", u.Name);
            u.Name = Console.ReadLine();
            //u.Name = null;--Error if we dont have a set acccessor
            // compile error
            // u.Location = "Delhi";// --Read only property....does not have set....so we cannot change value
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + u.Location);
            Console.WriteLine("Enter City");
            u.City = Console.ReadLine();//call the set accessor
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }

}


//Property is an extension of the class variable and it provides a mechanism to read, write or change the value of the class variable without affecting the external way of accessing it in our applications.

//In c#, properties can contain one or two code blocks called accessors and those are called a get accessor and set accessor. By using get and set accessors, we can change the internal implementation of class variables and expose it without effecting the external way of accessing it based on our requirements.
 
//Generally, in object-oriented programming languages like c# you need to define fields as private, and then use properties to access their values in a public way with get and set accessors.
 
//Following is the syntax of defining a property with get and set accessor in c# programming language.
 
//<access_modifier> <return_type> <property_name>
//{
//    get
//    {
//        // return property value
//    }
//    set
//    {
//        // set a new value
//    }
//}
//if you observe the above syntax, we used an access modifier and return type to define a property along with get and set accessors to make required modifications to the class variables based on our requirements.

//here, the get accessor code block will be executed whenever the property is read and the code block of set accessor will be executed whenever the property is assigned to a new value.

//in c#, the properties are categorized as three types, those are.
 
//type description
//read-write a property which contains a both get and set accessors, then we will call it as read-write property.
//read-only a property which contains only get accessor, then we will call it as a read-only property.
//write-only a property which contains only set accessor, then we will call it as write-only property.
//in c#, properties won’t accept any parameters and we should not pass a property as a ref or out parameter in our application.
 
//following is the simple example of defining a private variable and a property in c# programming language.
 
//class user
//{
//    private string name;
//    public string name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}
//if you observe the above example, we defined a property called “name” and we used a get accessor to return a property value and set accessors to set a new value.here, the value keyword in set accessor is used to define a value that is being assigned by set accessor.

//in c#, the get accessor needs to be used only to return the field value or to compute it and return it but we should not use it for changing the state of an object.
 
//as discussed, we can extend the behavior of class variables using properties get and set accessors.following is the example of extending the behavior of private variable in property using get and set accessors in c# programming language.
 


