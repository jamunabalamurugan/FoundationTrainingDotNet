using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEg
{
    class HashTableEg
    {
        static void Main()
        {
            Hashtable hs = new Hashtable();
            hs.Add(101, "Datastructure");
            hs.Add(102, "Artifical");
            hs.Add(103, "Java");
            foreach (DictionaryEntry d in hs)
            {
                Console.WriteLine("key:{0} && value:{1}", d.Key, d.Value);
            }
            hs.Remove(102);

            foreach (DictionaryEntry d in hs)
            {
                Console.WriteLine("key:{0} && value:{1}", d.Key, d.Value);
            }
            Console.Read();

        }
    }
}
