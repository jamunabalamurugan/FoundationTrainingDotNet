using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjAdoFirstApplication
{
    class Product
    {
        public int Productid { get; set; }
        public string Productname { get; set; }
        public int Category { get ; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return 
            "Product ID: " + Productid +
            "\tProduct Name: " + Productname +
            "\tProduct Price :  " + Price;
        }

        public string Display()
        {
            return 
            "\nProduct ID: " + "\tProduct Name: " + "\tProduct Category : " + "\tProduct Price :  "
            + "\n" + Productid + "\t" + Productname + "\t" + Category + "\t" + Price;
        }

    }
    class ProductRetrive
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        Product p;
        public ProductRetrive()
        {
            conn = new SqlConnection("Data Source=MSBEEYS\\HBSQLEXPRESS;Initial Catalog=Northwind;User Id=sa;Password=newuser123#");
            conn.Open();
            p = new Product();
        }
        public void ProductDisplay()
        {

            cmd = new SqlCommand("select * from Products", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p.Productid = (int)dr[0];
                p.Productname = (string)dr[1];
                p.Category = (int)dr[2];
                p.Price = Convert.ToDouble(dr[3]);

               // Console.WriteLine(p.Display());

                //or

                Console.WriteLine(p); //This will call the overriden toString() method of Product class
               

            }
        }

    }
    public class Client
    {
        public static void Main()
        {
            ProductRetrive pr = new ProductRetrive();
            int ch = 0;
            do {
                Console.WriteLine("1.Display Products 2.Add 3.Update 4.Delete 0.Exit");
                ch = int.Parse(Console.ReadLine());
                if (ch == 1)
                    pr.ProductDisplay();
                
            }while(ch!=0);

            Console.ReadKey();
        }
    }
}
