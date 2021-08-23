using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEg
{
    class DemoOverrrideEquals
    {
        static void Main(string[] args)
        {
            
            ATStudent s1 = new ATStudent(1, "Kavin", 10);
            ATStudent s2 = new ATStudent(2, "Kanav", 10);
            ATStudent s3 = s1;
            if (s1.Equals(s2))
            {
                Console.WriteLine("Both are equal");
            }
            else
                Console.WriteLine("Both are not equal....try again");
            Console.ReadKey();
        }
    }
    class ATStudent : IComparable<ATStudent>
    {
        int id;
        string name;
        int age;
        //Object obj;
        public ATStudent() { }
        public ATStudent(int id, string name)
        {
            this.id = id;
            this.name = name;
            //this.age = age;
        }
        public ATStudent(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public override bool Equals(object obj)
        {
            ATStudent s1 = this;
            ATStudent s2 = (ATStudent)obj;

            if (s1.age == s2.age/* && s1.Name == s2.Name*/)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Student Id : " + id + " Name : " + name;
        }
        public override int GetHashCode()
        {
            return id * 100;
        }
        public int CompareTo(ATStudent other)
        {
            //if (this.Id == other.Id)
            //    return 0;
            //else if (this.Id > other.Id)
            //    return 1;
            //else
            //    return -1;
            return this.Id.CompareTo(other.Id);
        }
        //Declaring a property for a member variable id of Student Class
        public int Id1
        {
            get { return id; }//accesor
            set { id = value; }//mutator
        }
        //or use Lamda Expression =>
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
