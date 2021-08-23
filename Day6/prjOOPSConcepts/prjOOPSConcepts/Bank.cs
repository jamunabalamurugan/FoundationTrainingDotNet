using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjOverridingExample
{
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
    class Manager : IEmployeeManager, ICustomerManager
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
            Console.WriteLine("Select your option.\n1.Customer\n2.Employee");
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
            else
                Console.WriteLine(@"Invalid Option ""No"" Byeeee.");
        }
    }
}//ask significance of @
