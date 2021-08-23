using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEg
{
    class SortedListEg
    {
        static void Main()
        {
            SortedList sl = new SortedList();

            sl.Add(7, "h");
            sl.Add(1, "A");
            sl.Add(9, "T");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine("key:{0} && Value:{1}", d.Key, d.Value);
            }
        }
    }
}
