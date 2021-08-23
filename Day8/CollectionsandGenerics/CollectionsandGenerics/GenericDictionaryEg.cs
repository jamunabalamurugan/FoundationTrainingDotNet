using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class GenericDictionaryEg
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "OOPS");
            dt.Add(2, ".NET");
            dt.Add(3, "OS");
            foreach(KeyValuePair<int,string>  k in dt)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }

            Console.Read();
        }

    }
}
