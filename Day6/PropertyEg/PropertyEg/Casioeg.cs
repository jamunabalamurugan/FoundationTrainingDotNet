using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEg
{
    class Casioeg : Calc,scicalc
    {
         int eno;
        public int Eno
        {
            get { return eno; }
            set { eno = value; }
        }
        public void add(int s,int l)
        {
            int temp = s + l;
            Console.WriteLine("Sum is "+temp);
        }
        //void scicalc.add(int x, int y)
        //{
        //    Console.WriteLine("This is the method of Scientific Calculator");
        //}

        public int div(int k,int l)
        {
            return k/ l;
        }

        public int mul(int k,int b)
        {
            return k * b;
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("The difference is "+Convert.ToInt32(a-b));
        }

        public void msg(string m)
        {
            Console.WriteLine("The message is "+m);
        }
    }



    class client
    {
        public static void Main()
        {

            Casioeg obj = new Casioeg();
            obj.add(10, 20);
            obj.sub(50, 40);
            int l = obj.mul(3, 7);
            int d = obj.div(20, 5);
            //sc.msg("Welcome");
            //sc.add(30, 50);
            obj.Eno = 10;
            Console.WriteLine(obj.Eno);
            Console.WriteLine("The product is "+l);
            Console.WriteLine("The qoutient is "+d);
            Console.Read();
        }
    }
}
