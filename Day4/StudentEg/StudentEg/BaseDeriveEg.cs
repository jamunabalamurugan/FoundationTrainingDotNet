using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEg
{

	class Base
	{
		public Base()
		{
			Console.WriteLine("Constructor of Base");
		}
		~Base()
		{
			Console.WriteLine("Destructor of Base");
		}
	}
	class Derived : Base
	{
		public Derived()
		{
			Console.WriteLine("Constructor of Derived");
		}
		~Derived()
		{
			Console.WriteLine("Destructor of Derived");
		}
	}
	class BaseDerived
	{
		static void Main(string[] args)
		{
			Derived obj = new Derived();//Base Constructor,Derived Constructor,Derived Destructor,Base Destructor
			Console.ReadKey();
			obj = null;
			GC.Collect();
			Console.ReadKey();
		}
	}

}
