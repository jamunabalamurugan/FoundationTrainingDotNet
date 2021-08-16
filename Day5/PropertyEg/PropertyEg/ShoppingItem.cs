using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class ShoppingItem
    {

        private string Category;
        private string nm;//Data member
        private string sz;
        private decimal price;

        public ShoppingItem()//Overloaded Default Constructor
        {
            price = 1;
            Category = "Babies";
            Console.WriteLine("Default Contructor called");
        }
        public ShoppingItem(string Category, string nm, string sz, decimal price)
        {

            this.Category = Category;
            this.nm = nm;
            this.sz = sz;
            this.price = price;
            Console.WriteLine("Parameterized Constructor Called");

        }
        // A property for the name of an item
        public string Name
        {
            get
            {
                return nm;
            }

            set
            {
                if (nm == "")
                    nm = "Item has no Description";
                else
                    nm = value;
            }
        }

        // A property for size of a merchandise
        public string Size
        {
            get
            {
                return sz;
            }

            set
            {
                sz = value;
            }
        }

        // A property for the marked price of an item
        public decimal UnitPrice
        {
            get
            {
                return price;
            }

            set
            {
                if (price < 0)
                    price = 0.00M;
                else
                    price = value;
            }
        }

        public string MyCategory
        {
            get { return Category; }//reading
            set { Category = value; }//writing or making changes
        }
        public static ShoppingItem Read()
        {

            ShoppingItem shop = new ShoppingItem();


            string cat;
            Console.WriteLine("Store Items Categories");
            Console.WriteLine("\t1. Women");
            Console.WriteLine("\t2. Men");
            Console.WriteLine("\t3. Girls");
            Console.WriteLine("\t4. Boys");
            Console.WriteLine("\t5. Babies");
            Console.Write("Enter the Category (1-5): ");
            cat = Console.ReadLine();
            if (cat == "1")
                shop.Category = "Women";
            else if (cat == "2")
                shop.Category = "Men";
            else if (cat == "3")
                shop.Category = "Girls";
            else if (cat == "4")
                shop.Category = "Boys";
            else if (cat == "5")
                shop.Category = "Babies";
            else
            {
                Console.WriteLine("Invalid item category");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.Write("Item Name:  ");
            shop.Name = Console.ReadLine();
            Console.Write("Number of units:  ");
            shop.Size = Console.ReadLine();
            Console.Write("Unit Price: ");
            shop.UnitPrice = decimal.Parse(Console.ReadLine());//set method of the UnitPrice property

            return shop;
        }

        public static void Write(ShoppingItem prod)
        {
            Console.WriteLine();
            Console.WriteLine("Category:    {0}", prod.Category);
            Console.WriteLine("Description: {0}", prod.Name);
            Console.WriteLine("Number of units:   {0}", prod.Size);
            Console.WriteLine("Unit Price:  {0:C}", prod.UnitPrice);//get method of the UnitPrice
        }
        public void Write()
        {
            Console.WriteLine();
            Console.WriteLine("Category:    {0}", this.Category);
            Console.WriteLine("Description: {0}", this.nm);
            Console.WriteLine("Number of units:   {0}", this.sz);
            Console.WriteLine("Number of units:   {0}", this.price);

        }

    }

    class UseShoppingItem
    {
        public static void Main(string[] args)
        {
            ShoppingItem si = new ShoppingItem("Men", "Shirt", "42", 1499);//Parameterized Cosntructor
            si = ShoppingItem.Read();
            ShoppingItem si2 = new ShoppingItem();//default constructor
            si2 = ShoppingItem.Read();
            ShoppingItem.Write(si2);
            si.Write();
            si2.Write();

            Console.WriteLine(si.Name);
            Console.WriteLine(si.MyCategory);//calling getter of the property called MyCategory
            si.MyCategory = "Kids";
            Console.ReadLine();
        }
    }
}
