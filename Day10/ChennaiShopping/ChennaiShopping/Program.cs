using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JamunaCreditCardValidation;
using CardValidationDLL;
namespace ChennaiShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //if(new CardCheck().validatecard("12345678901234568","VISA"))
            //    Console.WriteLine("Valid Card");
            //else
            //    Console.WriteLine("Invalid Card");

            if(new CreditCard().Validate("4722540009106018"))
            {
                Console.WriteLine("Valid Card from GAC Util");
            }
            else
                Console.WriteLine("Invalid Card  no from GAC Util");
            Console.ReadKey();
        }
    }
}
