using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class SortedListeg
    {
        static void Main()
        {
            SortedList st = new SortedList();
            st.Add("A001", "JAVA");
            st.Add("A002", "ORACLE");
            st.Add("A003", "CompleteGuide");
            st.Add("A004", "Azure");

            foreach (DictionaryEntry dt in st)
            {
                Console.WriteLine(dt.Key + " " + dt.Value);
            }

            Console.Read();
        }
    }
}
