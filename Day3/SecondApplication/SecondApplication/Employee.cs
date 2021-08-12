using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondApplication
{
    enum City { Delhi,Mumbai,Chennai,Hyderbad,Bangalore};
    enum Month { Jan=1,Feb,Mar};
    class Employee
    {
        enum Days { Mon,Tue,Wed};
        static void Main()
        {
            int Empid = 1001;
            string Name = null;
            string address = null;
            //primitive data type or value types cannot store null
            int age = 0;
            Console.WriteLine("age is {0}", age);
            //Nullable type
            int? Age = null;

            string empcity = "xyz";
            City ecity=City.Delhi;
            Days eDayofRecruitment = Days.Mon;
            Month erecruitmentmonth = Month.Feb;

            Console.WriteLine(ecity);
            Console.WriteLine(erecruitmentmonth);

            if(Age==null)
            {
                Console.WriteLine("Age cannot be null...please enter a value");
                Age = 4;
            }
            else
            {
                Console.WriteLine(Age);
            }
            int? status=(Age == null) ? 0 : Age;//ternary operator
            int stat=(age == null) ? 0 : age;
            //Null coalescing operating
            Console.WriteLine("The Age is :{0}", Age ?? 4);
            
            int Result = Age ?? 4;
            Console.WriteLine(Result);

            Name = Name ?? "Name has to be filled";
            Console.WriteLine(Name);
            Console.Read();
        }
    }
}
