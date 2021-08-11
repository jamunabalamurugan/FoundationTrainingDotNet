using System;
public enum ItemCategory
    {
        Women,
        Men,
        Girls,
        Boys,
        Babies
    }

    class ShoppingItems
    {
       
        private ItemCategory Category;
        private string Name;
        private int Size;
        private decimal UnitPrice;


        public static ShoppingItems Read()
        {
            string category;
            ShoppingItems shop = new ShoppingItems();

           
          
            Console.WriteLine("Categories");
            Console.WriteLine("\t1. Women");
            Console.WriteLine("\t2. Men");
            Console.WriteLine("\t3. Girls");
            Console.WriteLine("\t4. Boys");
            Console.WriteLine("\t5. Babies");
            Console.Write("Enter the Category Number(1-5): ");
            category = Console.ReadLine();
            if (category == "1")
                shop.Category = ItemCategory.Women;
            else if (category == "2")
                shop.Category = ItemCategory.Men;
            else if (category == "3")
                shop.Category = ItemCategory.Girls;
            else if (category == "4")
                shop.Category = ItemCategory.Boys;
            else if (category == "5")
                shop.Category = ItemCategory.Babies;
	    else 
		{
			Console.WriteLine("Invalid item category");
			System.Environment.Exit(0);
			Console.ReadLine();
		}     
            Console.Write("Item Name:  ");
            shop.Name = Console.ReadLine();
            Console.Write("Number of units:  ");
            shop.Size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unit Price: ");
            shop.UnitPrice = decimal.Parse(Console.ReadLine());

            return shop;
        }

        public static void Write(ShoppingItems item)
        { 
            Console.WriteLine();
	    Console.WriteLine("Category:    {0}", item.Category);
            Console.WriteLine("Description: {0}", item.Name);
            Console.WriteLine("Number of units:   {0}", item.Size);
            Console.WriteLine("Unit Price:  {0:C}", item.UnitPrice);
          
        }

                public static void Main(string []args)
                {
                    ShoppingItems si =new ShoppingItems();
                    si=ShoppingItems.Read();
                    ShoppingItems.Write(si);
		    Console.ReadLine();
                }
    }
