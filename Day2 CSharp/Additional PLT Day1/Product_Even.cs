using System;
using System.Collections.Generic;
using System.Text;

namespace Divisible
{
    class Product_Even
    {
        static void Main(string[] args)
        {
            int nNum, nEven;
	    double nProd;
            nNum = 2; nEven = 0; nProd = 1;
            while (nEven < 10)
            {
 	            nProd = nNum * nProd;
  	            nNum = nNum + 2;
  	            nEven = nEven + 1;
            }
            Console.WriteLine("The product of first 10 even numbers is:{0} ",nProd);

        }
    }
}
