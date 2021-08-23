using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{

//    Interfaces summary
//An interface has the following properties:

//In C# versions earlier than 8.0, an interface is like an abstract base class with only abstract members. A class or struct that implements the interface must implement all its members.
//Beginning with C# 8.0, an interface may define default implementations for some or all of its members. 
    //A class or struct that implements the interface doesn't have to implement members that have default implementations.
    //For more information, see default interface methods.
//An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
//A class or struct can implement multiple interfaces.A class can inherit a base class and also implement one or more interfaces.
    interface ISalesManager
    {
        void GenerateCustomer();
        void IncreasePurchase();
    }
    interface ICustomerManager
    {
        void ApproveLoan();
        void SolveQueries();
    }
    interface IEmployeeManager
    {
        void SetTarget();
        void ConductMeeting();
    }
    class Manager : IEmployeeManager, ICustomerManager, ISalesManager
    {
        public void ApproveLoan()
        {
            Console.WriteLine("Congrats your loan is approved");
        }
        public void ConductMeeting()
        {
            Console.WriteLine("Lets meet its official");
        }
        public void SetTarget()
        {
            Console.WriteLine("Here is your Client List....Retain existing and add new Clients ");
        }

        public void SolveQueries()
        {
            Console.WriteLine("What is issue?...We will solve within two working days");
        }

        void ISalesManager.GenerateCustomer()
        {
            Console.WriteLine("Sale Announced for Customers");
        }

        void ISalesManager.IncreasePurchase()
        {
            Console.WriteLine("Conduct Training for Sales Team to handle Customer enquiry and convert to Sale");
        }
    }
    class Bank
    {
        static void Main(string[] s)
        {
            Bank ififi = new Bank();
            ififi.Banking();
            Console.ReadKey();
        }
        private void Banking()
        {
            string strSelect;
            Manager mgr = new Manager();
            Console.WriteLine("Welcome to IFIFI bank");
            Console.WriteLine("Select your option.\n1.Customer\n2.Employee\n3.Sales");
            strSelect = Console.ReadLine();
            if (strSelect == "1")
            {

                ICustomerManager cmgr = mgr;
                //ICustomerManager cmgr = new ICustomerManager();
                cmgr.ApproveLoan();
                cmgr.SolveQueries();

            }
            else if (strSelect == "2")
            {
                IEmployeeManager emgr = mgr;
                emgr.ConductMeeting();
                emgr.SetTarget();

            }
            else if (strSelect == "3")
            {
                ISalesManager smgr = mgr;
                smgr.GenerateCustomer();
                smgr.IncreasePurchase();
            }
            else
                Console.WriteLine(@"Invalid Option ""No"" Byeeee.");
        }
    }
}
