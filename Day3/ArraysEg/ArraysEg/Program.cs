using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEg
{
    class Program
    {
        public void SDArray()
        {
            string[] fruits = { "Apple", "Orange", "Banana", "Kiwi", "Peaches", "Plums", "Lychee" ,"Mango"};

            //A100,A200,A300,A400,
            double[] prices = { 150, 70, 40, 200, 250, 300, 250 };

           

            //D40,D48,D54
            foreach (string fruit in fruits)
            {
                if(fruit[0]=='P')
                Console.WriteLine(fruit);
            }
        }
        public void TDArray()
        {
            int[,] Marks = new int[8, 6] {
                {1,91,96,85,89,100 },
                {2,92,96,85,89,100 },
                {3,93,96,85,89,100 },
                {4,94,96,85,89,100 },
                {5,95,96,85,89,100 },
                {6,96,96,85,89,100 },
                {7,97,96,85,89,100 },
                {8,98,96,85,89,100 }
            };

            Console.WriteLine("The {0} sem marks are {1},{2},{3},{4},{5}", Marks[0,0], Marks[0,1], Marks[0,2], Marks[0,3], Marks[0,4],Marks[0,5]);
            Console.WriteLine("The {0} sem marks are {1},{2},{3},{4},{5}", Marks[1,0], Marks[1, 1], Marks[1, 2], Marks[1, 3], Marks[1, 4], Marks[1, 5]);

            //foreach (var semester in Marks)
            //{
            //    Console.WriteLine("The semester marks is ");
            //}
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.SDArray();
            //int[] quantity = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    quantity[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int q in quantity)
            //{
            //    Console.WriteLine("The quanity is "+q);
            //}
            p.TDArray();
            Console.ReadKey();
        }
    }
}
