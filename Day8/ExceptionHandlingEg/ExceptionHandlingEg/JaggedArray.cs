using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingEg
{
    class JaggedArray
    {
        static void Main()
        {
            //declaring an Jagged array
            int[][] arr = new int[2][];

            arr[0] = new int[3] { 10, 20, 30 };
            arr[1] = new int[2] { 1, 2 };

            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr[j].Length; i++)
                {
                    Console.WriteLine("Jagged array{0}", arr[j][i]);
                }

            }
            Console.Read();
        }
    }
}
