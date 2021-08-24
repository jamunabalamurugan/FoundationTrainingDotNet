using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Program
    {
        void ShowingArrayProblem()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 2; i++)
            {
                numbers[i] = i + i * 10 + 5;
            }
            //numbers = new int[10];
            //numbers[6] = 20;
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingArrayListCollection()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(100.3f);
            list.Add("Hello");
            list.Add("36.3");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted list");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        void UnderstandingTroubleWithListCollection()
        {
            ArrayList list = new ArrayList();//it is not type safe
            list.Add(10);
            list.Add(100.3f);
            list.Add("Three");
            list.Add("36.3");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted list");
            double sum = 0;
            foreach (var item in list)
            {
                sum = sum + Convert.ToDouble(item);//type exception
            }
            Console.WriteLine(sum);
        }
        void UnderstandingGenricList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(80);
            numbers.Add(75);
            numbers.Add(87);
            numbers.Add(60);
            numbers.Add(40);
            Console.WriteLine("The elements");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("After Sorting");
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("The position 2 is " + numbers[1]);
        }
        void UnderstandingStack()
        {
            Stack<string> names = new Stack<string>();
            names.Push("Hello");
            names.Push("Kavin");
            names.Push("Kanav");
            names.Push("Sumedha");
            names.Push("Saadhana");
            Console.WriteLine("Please enter a name to inserted");
            names.Push(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.WriteLine("Poping the element from stack----" + names.Pop());
            Console.WriteLine("After Pop");
            Console.WriteLine("Number of elements present " + names.Count);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            //peek will not pop
            Console.WriteLine("Peeking in to check the next item -----" + names.Peek());
            Console.WriteLine("After Peek");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        void UnderstandingQueue()
        {
            Queue<Student> students = new Queue<Student>();
            students.Enqueue(new Student(101, "Kavin"));
            Console.WriteLine("Please enter student ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            string name = Console.ReadLine();
            Student student = new Student();
            student.Id = id;
            student.Name = name;
            students.Enqueue(student);
            Console.WriteLine("Items prent in queue are");
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }
            Console.WriteLine("The element from queue " + students.Dequeue());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Items after dequeue are");
            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }

        }
        void UnderstandingLinkedList()
        {
            LinkedList<float> ll = new LinkedList<float>();
            ll.AddFirst(0f);
            LinkedListNode<float> node = ll.First;
            node.Value = 12.3f;
            //ll.AddFirst(12.2f);
            ll.AddAfter(ll.First, 34.5f);
            ll.AddLast(90.4f);
            Console.WriteLine("Please enter a number to be added before last");
            float value = float.Parse(Console.ReadLine());
            ll.AddBefore(ll.Last, value);
            Console.WriteLine("The elements in the linked list are");
            foreach (float num in ll)
            {
                Console.WriteLine(num);
            }
            ll.AddAfter(ll.First, 45.5f);
            Console.WriteLine("The elements in the linked list after editing are");
            foreach (float num in ll)
            {
                Console.WriteLine(num);
            }
            node = ll.Find(34.5f);
            ll.AddAfter(node, 33.33f);
            Console.WriteLine("The elements in the linked list after editing inbetween  are");
            foreach (float num in ll)
            {
                Console.WriteLine(num);
            }
            node = ll.Find(33.33f);
            Console.WriteLine(node.Value);
            node.Value = 45.88f;

        }
        void UsingStudentLinkedList()
        {
            LinkedList<Student> students = new LinkedList<Student>();
            students.AddFirst(new Student(101, "Kavin"));
            students.AddLast(new Student(102, "Kanav"));
            Student s = new Student(101, "Kavin");
            LinkedListNode<Student> node = students.Find(s);
            if (node != null)
                Console.WriteLine(node.Value);
            else
                Console.WriteLine("No such node");
        }


        void UnderstandingEquals()
        {
            int num1 = 10, num2 = 10;
            string str1 = "Kavin", str2 = "Kanav";
            Student student1 = new Student(101, "Kavin");
            Student student2 = new Student(101, "Kavin");
            //if (student1.Id == student2.Id && student2.Name == student1.Name)//compare the values
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not equal");
            if (student1.Equals(student2))//compare the whatever
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");
        }
        void UnderstandingSort()
        {
            //List<string> list = new List<string>();
            //list.Add("Kavin");
            //list.Add("Kanav");
            //list.Add("Saadhana");
            //list.Add("Sumedha");
            //list.Add("Saahithya");
            //Console.WriteLine("Original order");
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Sort();
            //Console.WriteLine("After Sort");
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Arun"));
            students.Add(new Student(103, "Arav"));
            students.Add(new Student(105, "Umesh"));
            students.Add(new Student(102, "Bala"));
            students.Add(new Student(104, "Maha"));
            Console.WriteLine("Original order");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            students.Sort();
            Console.WriteLine("after sort");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

        }
        void UnderstandingHashSet()
        {
            //HashSet<double> hs = new HashSet<double>();
            //hs.Add(12.33);
            //hs.Add(456.4);
            //hs.Add(77.4);
            //hs.Add(765.4);
            //hs.Add(77.4);
            //foreach (double item in hs)
            //{
            //    Console.WriteLine(item);
            //}
            HashSet<Student> students = new HashSet<Student>();
            Student s1 = new Student(101, "Kavin");
            Student s2 = s1;
            students.Add(s1);
            students.Add(s2);
            //students.Add(new Student(103, "Kanav"));
            //students.Add(new Student(101, "Kavin"));

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            if (students.Contains(new Student(103, "Kanav")))
                Console.WriteLine("Present");
            else
                Console.WriteLine("Not available");
            //sorting the data
            List<Student> stuList = new List<Student>();
            stuList.AddRange(students);
            stuList.Sort();
            //removing the data
            students.Remove(new Student(101, "Kavin"));
            Console.WriteLine("After removing");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        void UnderstandingDictionary()
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(10, "Kavin");
            myDictionary.Add(56, "Kanav");
            myDictionary.Add(9, "Sumedha");
            myDictionary.Add(11, null);
            if (!myDictionary.ContainsKey(10))
                myDictionary.Add(10, "Saadhana");
            //access a member of a dictionary
            myDictionary[30] = "Saahithya";
            foreach (int item in myDictionary.Keys)
            {
                Console.WriteLine("Key : " + item + " Value : " + myDictionary[item]);

            }
            //In the sorted order of key
            Console.WriteLine("Sorted order of keys");
            List<int> keys = myDictionary.Keys.ToList();
            keys.Sort();
            foreach (int item in keys)
            {
                Console.WriteLine("Key : " + item + " Value : " + myDictionary[item]);

            }
        }

        void UnderstandingNullableTypes()
        {
            string name = null;
            int marks = 0;
            int? i = 90;//nullable integer
            marks = (int)i;
            Console.WriteLine("Marks is having value of i : {0}",marks);
            string s = null;
            i = null;
            //i = 10 * 20 + 30;
            i = i == null ? 10 : i;//Ternary Operator
            i = i ?? 10;//null coalescing operator
            i = 10 * 20 + 30;
            Console.WriteLine("The valuue of i is " + i);
        }
        void AddValue(int num1)
        {
            Console.WriteLine("In Add before change " + num1);
            num1++;
            Console.WriteLine("In Add after change " + num1);
        }
        void AddRef(ref int num1)
        {
            Console.WriteLine("In Add Ref before change " + num1);
            num1++;
            Console.WriteLine("In Add Ref after change " + num1);
        }
        void UnderstandingValueTypeAndRefType()
        {
            int n1 = 100;
            Console.WriteLine("In calling method before call " + n1);
            AddValue(n1);
            Console.WriteLine("In calling method after call " + n1);
            Console.WriteLine("------------------------------------");
            int n2 = 100;
            Console.WriteLine("In calling method before call " + n2);
            AddRef(ref n2);
            Console.WriteLine("In calling method after call " + n2);
        }
        double ExampleWithOut(int num1, out int num2)
        {
            num1 = 200;
            Console.WriteLine(num1);
            //Console.WriteLine(num2+" is what it brought");
            num2 = num1 + 20 * 100 - 234;
            return (num2 / num1);
        }
        void UnderstandingOutParameter()
        {
            int n1 = 100, n2 = 100;
            double dNum = ExampleWithOut(n1, out n2);
            Console.WriteLine("the return value is " + dNum);
            Console.WriteLine("After the method call with out parameter " + n2);
        }
        void UnderstandingHashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(10, "ONe");
            ht.Add(2, "ONe");
            ht.Add(6, "ONe");
            ht.Add(5, "ONe");
            ht.Add(8, "ONe");
            //keys = (ArrayList)ht.Keys;
            ArrayList list = new ArrayList();
            list.AddRange(ht.Keys);
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item + " " + ht[item]);
            }
        }
        static void Main(string[] args)
        {
            new Program().UnderstandingNullableTypes();
                Console.ReadKey();
        }
    }
    class Student : IComparable<Student>
    {
        int id;
        string name;
        //Object obj;
        public Student() { }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override bool Equals(object obj)
        {
            Student s1 = this;
            Student s2 = (Student)obj;

            if (s1.Id == s2.Id && s1.Name == s2.Name)
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
        public int CompareTo(Student other)
        {
            //if (this.Id == other.Id)
            //    return 0;
            //else if (this.Id > other.Id)
            //    return 1;
            //else
            //    return -1;
            return this.Id.CompareTo(other.Id);
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}