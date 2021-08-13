using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseStudentEg
{
	using System;
	public class Student
	{
		protected internal string firstname, identity;

		public Student()
        {
			firstname = "Kavin";
			identity = "100";
            Console.WriteLine("Student Default Constructor");
        }
		public Student(string name, string id)//Parametrised contructor of Base Class
		{
            Console.WriteLine("Student Para Constructor called");
			firstname = name;
			identity = id;
		}
		public string getName()
		{
			return firstname;
		}
		protected string getId()
		{
			return identity;
		}
		~Student()
		{
		}
	}

	//This type of Inheritance is called Single Inheritance
	public class HostelStudent : Student
	{
		private int roomno;  //Attributes inherited from base class-- firstname,identity and directly access them only if protected access is given

		//public HostelStudent(string name, string id, int r)   //It calls the default constructor of Base class only

		public HostelStudent(string name, string id, int r) : base(name, id)  //Calling the base class parameterised constructor
		{
            Console.WriteLine("HostelStudent Para Constructor called");
			roomno = r;
		}
		public void getDetails()
		{
			//Console.WriteLine("Private Only with get method"+"Name is {0},ID is {1}, and room number is {2}", getName(), getId(), roomno);
			Console.WriteLine("Protected - Direct Access "+"Name is {0},ID is {1}, and room number is {2}", firstname, identity,roomno);
		}
		

	}

	//Multilevel Inheritance
	//protected:allows only access to child class
	//The child class can be same assembly as protected class or from another assembly

	//protected internal:allows a class to expose its member variables and functions to the child class or classes within the same assembly

	//internal:Allows a class to expose its members to other class within the same assembly in which the member is defined
	public class FinalYearStudent:HostelStudent
    {
		string LaptopModel;
		int NoOfDaysInternship;

		public FinalYearStudent(string name,string id,int rno,string lm,int days):base(name,id,rno)
        {
            Console.WriteLine("Final Year Hostel Student constructor called");
			LaptopModel = lm;
			NoOfDaysInternship = days;
			firstname = name + "Kumar";//Only protected members of super base class can be accessed in grand child class
			
        }
    }
	public class Program
    {
		public static void Main(string[] args)
		{
			//HostelStudent hs = new HostelStudent("Kanav", "001", 6);
			/* calling the constructor of the derived class */
			FinalYearStudent hs = new FinalYearStudent("Kanav", "001", 6, "I7", 60);
			hs.getDetails();

            //Console.WriteLine(hs.getName()+"\t"+hs.getId());//Error-Cannot access a protected member from another class....only derived class can access protected members
            Console.WriteLine(hs.firstname+"\t"+hs.identity);
			Console.ReadKey();
		}
	}
}