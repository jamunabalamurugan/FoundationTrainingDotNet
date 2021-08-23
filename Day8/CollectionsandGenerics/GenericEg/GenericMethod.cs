using System;
using System.Collections.Generic;


namespace GenericEg
{
    class Student<T> where T:class
    {
        T phno;
       public dynamic Total<T>(T Maths,T Science1,T Science2)
        {
            dynamic m = Maths;
            dynamic s1 = Science1;
            dynamic s2 = Science2;
            return m +s1+s2;
        }
       public void GetData<T>(T Name,T City)
        {
            Console.WriteLine(Name + " " + City);
        }
    }
    class GenericMethod
    {
        static void Main()
        {
            Student<string> sobj = new Student<string>();
            double total = sobj.Total<float>(50.78f, 99.999f, 88.78f);

            Console.WriteLine(total);
           // Console.WriteLine(sobj.Total<double>(60.45,78.77,85.60));

            sobj.GetData<string>("ddf", "chennai");
            Console.Read();
        }
    }
}
