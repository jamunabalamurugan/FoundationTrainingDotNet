using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEg
{
    class ArrayListEg
    {
        static void Main()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Doll");
            al.Add(23.04);
            al.Add(100);
            al.Add(67.90);

            foreach (var o in al)
            {
                Console.WriteLine("Element in arraylist: {0}", o);
            }

            Console.WriteLine("capacity:{0}", al.Capacity);
            Console.WriteLine("Count:{0}", al.Count);
            al.Remove("Doll");
            al.RemoveAt(2);
            al.Sort();
            ArrayList al1 = new ArrayList();
            al1.Add("newlist");
            al1.Add(200);


            al.AddRange(al1);


            Console.WriteLine("After Deletion");
            foreach (object o in al)
            {
                Console.WriteLine("Elemet in arraylist: {0}", o);

            }

            Console.Read();

        }
    }
}
