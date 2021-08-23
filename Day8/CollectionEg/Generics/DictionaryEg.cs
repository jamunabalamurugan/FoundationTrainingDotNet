using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DictionaryEg
    {
        static void Main()
        {
            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("cs", "cs.net");
            dct.Add("V", "vb.net");
            dct.Add("b", "vb.net");
            dct.Add("n", "vb.net");
           // dct.Add("n", "vc++.net");

            foreach (var kvp in dct)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);

            }
            Console.Read();
        }
    }
}
