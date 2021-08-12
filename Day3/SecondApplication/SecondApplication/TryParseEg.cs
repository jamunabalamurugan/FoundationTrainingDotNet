using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    class TryParseEg
    {
        static void Main()
        {
            string Oil = "10";
            //  int quantity =Convert.ToInt32(Oil);
            // int quantity = int.Parse(Oil);
            int quantity;
         bool ischeck   = int.TryParse(Oil, out quantity);

            if(ischeck)
            {
                Console.WriteLine("Request Accepted");
                
                int amount = quantity * 100;
                Console.WriteLine("Bill Amount is{0}",amount);
            }
            else
            {
                Console.WriteLine("Enter the correct value");
            }
              
            
            Console.Read();

        }
    }
}
