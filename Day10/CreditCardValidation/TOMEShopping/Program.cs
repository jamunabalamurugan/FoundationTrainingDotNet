using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JamunaCreditCardValidation;
namespace TOMEShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter Card no");
            string cardno = Console.ReadLine();
            Console.WriteLine("Enter Carrd Type");
            string cardtype = Console.ReadLine();
           CardCheck ccobj = new CardCheck();
            bool status=ccobj.validatecard(cardno, cardtype);
            if(status )
                Console.WriteLine("Valid Card No");
            else
                Console.WriteLine("Invalid Card No");

            Console.ReadKey();
        }
    }
}
