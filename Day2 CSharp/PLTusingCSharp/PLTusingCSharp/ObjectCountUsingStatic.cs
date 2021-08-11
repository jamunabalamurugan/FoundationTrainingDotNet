using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLTusingCSharp
{
    class ObjectCount
    {
        public static int count=0;//static variable shares the value of it among all instances of the class.
        public static void MethodSample()
        {
            Console.WriteLine("Its a static method");
        }
        public void ObjectCounter()
        {
            count++;
        }
        public int display()
        {

            return count;
        }

    }
    class UseObjectCount
    {
        public static void Main()
        {
            ObjectCount obj1 = new ObjectCount();
            obj1.ObjectCounter();
            obj1.ObjectCounter();

            Console.WriteLine(obj1.display());

            ObjectCount obj2 = new ObjectCount();
            obj2.ObjectCounter();
            Console.WriteLine(obj2.display());

            ObjectCount obj3 = new ObjectCount();
            obj3.ObjectCounter();
            Console.WriteLine(obj3.display());

            Console.WriteLine(ObjectCount.count);

            ObjectCount.MethodSample();
            //ObjectCount.display();
            Console.ReadKey();
        }
    }
}
