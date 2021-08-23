using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
    public class ParamsEg
    {
        public static void Display1(string myname ,params int[] mynumbers)
        {
            int total = 0;
            for (int i = 0; i < mynumbers.Length; i++)
            {
                //Console.Write(mynumbers[i] + " ");
                Console.WriteLine();
                total += mynumbers[i];
                //Console.WriteLine(new List<int>());
               
            }
            float average = total / mynumbers.Length;
            Console.WriteLine("The count of nos: {0} and Total is : {1}",mynumbers.Length,total);
            Console.WriteLine();
        }

        public static void Display2(params object[] myobjects)
        {
            for (int i = 0; i < myobjects.Length; i++)
            {
                Console.Write(myobjects[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // You can send a comma-separated list of arguments of the
            // specified type.
            Display1("Hello",1, 2, 3, 4,50,34,78,56,45,57);

            Display2(1, 'a', "test",new List<float>());

            //// A params parameter accepts zero or more arguments.
            //// The following calling statement displays only a blank line.
            Display2();

            //// An array argument can be passed, as long as the array
            //// type matches the parameter type of the method being called.
            int[] myIntArray = { 5, 6, 7, 8, 9 };
            Display1("Hello",myIntArray);

            object[] myObjArray = { 2, 'b', "test", "again" };

            ArrayList al = new ArrayList();
            al.Add(10);
            Queue qobj = new Queue();
            qobj.Enqueue(20);
            Display2(al,qobj);

            //// The following call causes a compiler error because the object
            //// array cannot be converted into an integer array.
            Display1("Hello",myIntArray);

            //// The following call does not cause an error, but the entire
            //// integer array becomes the first element of the params array.
            //Display2(myIntArray);
            Console.ReadKey();
        }
    }
}

//By using the params keyword, you can specify a method parameter that takes a variable number of arguments.The parameter type must be a single-dimensional array.

//No additional parameters are permitted after the params keyword in a method declaration, and only one params keyword is permitted in a method declaration.

//If the declared type of the params parameter is not a single-dimensional array, compiler error CS0225 occurs.


//When you call a method with a params parameter, you can pass in:


//A comma-separated list of arguments of the type of the array elements.
//An array of arguments of the specified type.
//No arguments. If you send no arguments, the length of the params list is zero.
