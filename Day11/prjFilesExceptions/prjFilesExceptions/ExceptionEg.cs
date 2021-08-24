using prjFilesExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
	class BankException : ApplicationException  //user-defined exception
	{
		//statement write here
		public BankException(string msg) : base(msg)//constructor of BankException calling bse class constructor
		{

		}
	}
	class Transaction
	{
		public void Withdraw()
		{
			try
			{
				//statements
				Console.WriteLine("Enter the withdrawal amount");
				double amount = double.Parse(Console.ReadLine());
				if (amount > 50000 || amount < 100)
				{
					BankException b = new BankException("Invalid Amount...Pls withdraw only between 100-50000");
					throw b;//raise exception
				}
			}
			catch (BankException be)
			{
				//statements
				Console.WriteLine("Sorry...." + be.Message);
			}
			catch (FormatException fe)
			{
				Console.WriteLine("Incorrect No entered for withdrawl" + fe.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine("Unknown error has occured " + e.StackTrace);
			}
			finally
			{
				Console.WriteLine("Customer has tried to Withdraw");
			}
		}
	}

}



class UseTransaction
{
	static void Main()
	{
		Transaction tobj = new Transaction();
		while (true)
		{
			tobj.Withdraw();
		}
		Console.ReadKey();

	}
}

