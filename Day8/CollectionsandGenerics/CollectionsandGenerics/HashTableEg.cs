using System;
using System.Collections;


namespace CollectionsandGenerics
{
    class HashTableEg
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();//Uses a key to access the elements in the collection....Use a hash table when you must access elements by using an index Eg... Access Book Tiytles witheir ISBN numebrs
            ht.Add(1, "JAVA");
            ht.Add(2, "ORACLE");
            ht.Add("A", "CompleteGuide");

            foreach(DictionaryEntry dt in ht)
            {
                Console.WriteLine(dt.Key + " " + dt.Value);
            }

            Queue myqueue = new Queue();//FIFO collection of Object
            Stack myobj = new Stack();//LIFO

            Console.WriteLine("SortedList");
            SortedList st = new SortedList();
            st.Add("A001", "JAVA");
            st.Add("A002", "ORACLE");
            st.Add("A003", "CompleteGuide");

            foreach (DictionaryEntry dt in st)
            {
                Console.WriteLine(dt.Key + " " + dt.Value);
            }
            Console.Read();
        }
    }
}
