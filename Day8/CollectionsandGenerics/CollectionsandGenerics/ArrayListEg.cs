using System;
using System.Collections;


namespace CollectionsandGenerics
{
    //Represents the ordered Collection of an Object that can be individually indexed
    //Is used when you want to access elements by using an index
    //Items can be inserted or removed at any position
    class ArrayListEg
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add("Kavin");
            al.Add(20.09);
            foreach(object item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count:"+al.Count);
            Console.WriteLine("Capacity:" + al.Capacity);

            al.Add("Kanav");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Count:" + al.Count);
            Console.WriteLine("Capacity:" + al.Capacity);

            al.Remove(20);
            al.RemoveAt(3);
            al.Contains("Kanav");
            Console.WriteLine("Capacity:" + al.Capacity);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity:" + al.Capacity);
            Console.Read();
        }
    }
}


//10,20,Kavin,