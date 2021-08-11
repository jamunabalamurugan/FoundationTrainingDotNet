using System;

namespace MenuApplication
{
    class Menu
    {
        int no;
        public void displayMenu()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t************ APPLICATION MENU ************");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t1. CREATE PATTERNS\n\t\t\t2. ADD PRIMARY COLORS\n\t\t\t3. JUMBLED WORDS\n\t\t\t4. PUZZLE");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t*******************************************");

        }
        public void AcceptData()
        {
            Console.WriteLine("\n\t\tPlease enter the application number for the details:");

            no = Convert.ToInt32(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("This application will allow you to create a pattern in pyramid structure.");
                    break;
                case 2:
                    Console.WriteLine("This application will allow you to add two primary colors and displays the third color.");
                    break;
                case 3:
                    Console.WriteLine("This application will allow you to create a meaningful word from jumbled letters.");
                    break;
                case 4:
                    Console.WriteLine("This application will allow you to create multiple words from a single word.\nEach correct word will increase your score by 1.");
                    break;
                default:
                    Console.WriteLine("Not a valid menu number");
                    break;
                    Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.displayMenu();
            menu.AcceptData();

        }
    }
}
