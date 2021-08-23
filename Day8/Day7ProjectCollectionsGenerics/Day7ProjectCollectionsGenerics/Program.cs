using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ProjectCollectionsGenerics
{
  
        class Program
        {
            void UnderstandingCollection()
            {
                ArrayList al = new ArrayList();
                al.Add(10);
                al.Add(12.3f);
                al.Add("Hello");
                al.Add(123.2);
                al.Add(new Object());
                al.Add("Hello");
                foreach (var item in al)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("The capacity of the collection is " + al.Capacity);
                al.TrimToSize();
                Console.WriteLine("The capacity of the collection after trim is " + al.Capacity);
                al.Add("Hello");
              
                double sum = 0;
                //foreach (var item in al)
                //{
                //sum += Convert.ToDouble(item);

                // }
            }
            void UnderstandingList()
            {
                List<int> intList = new List<int>();
                intList.Add(123);
                intList.Add(254);
                intList.Add(12);
                intList.Add(476587);
                intList.Add(12);
                foreach (int item in intList)
                {
                    Console.WriteLine(item);
                }
                intList.Sort();
                Console.WriteLine("After sort");
                foreach (int item in intList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("the element in position 3 is " + intList[2]);
            }
            void UnderstandingMoreAboutList()
            {
                List<string> names = new List<string>();
                names.Add("Kavin");
                names.Add("Kanav");
                names.Add("Kayan");
                names.Add("Arun");
                names.Sort();
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
                List<Employee> employees = new List<Employee>();
                int choice = 0;
                do
                {
                    Employee employee = new Employee();
                    employee.TakeEmployeeData();
                    employees.Add(employee);
                    Console.WriteLine("Enter a number > 0 to continue. 0 to exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice > 0);
                employees.Add(new Employee(101, "Kavin", 32423));
                employees.Add(new Employee(102, "Kanav", 2131));
                employees.Add(new Employee(103, "Kayan", 353687));
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp);
                    Console.WriteLine("------------------------");
                }
                employees.Sort(new EmployeeNameSort());
                Console.WriteLine("After sort");
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp);
                    Console.WriteLine("------------------------");
                }
                Employee checkEmployee = new Employee(102, "Arun", 2131);
                if (employees[1].Equals(checkEmployee))
                    Console.WriteLine("Both Employees are Matching");
                else
                    Console.WriteLine("Not Matching");
                Console.WriteLine("Does it contain the employee with id 102?? " + employees.Contains(checkEmployee));
            }
            void UnderstandingStack()
            {
                Stack<float> numberStack = new Stack<float>();
                numberStack.Push(123.4f);
                numberStack.Push(455.4f);
                numberStack.Push(866.2f);
                numberStack.Push(334.5f);
                foreach (float item in numberStack)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("number of elements in stack now " + numberStack.Count);
                Console.WriteLine("Lets pop the element " + numberStack.Pop());
                Console.WriteLine("number of elements in stack now " + numberStack.Count);
                //gives back what the next retrivable element is but does not remove it
                Console.WriteLine("Lets not pop but lets peek what is the next element " + numberStack.Peek());
                Console.WriteLine("number of elements in stack now " + numberStack.Count);
            }
            void UnderstandingQueue()
            {
                Queue<string> names = new Queue<string>();
                names.Enqueue("Kavin");
                names.Enqueue("Kanav");
                names.Enqueue("Sumedha");
                names.Enqueue("Saadhana");
                names.Enqueue("Joshitha");
                foreach (var item in names)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Deque check " + names.Dequeue());
                Console.WriteLine("Count after dequque " + names.Count);
                Console.WriteLine("Peek check " + names.Peek());
                Console.WriteLine("Count after peek " + names.Count);
            }
            void UnderstandingDictionary()
            {
                Dictionary<int, string> pairs = new Dictionary<int, string>();
                pairs.Add(101, "Kavin");
                pairs.Add(102, "Kanav");
                pairs.Add(103, "Sumedha");
                pairs.Add(104, "Saadhana");
                pairs.Add(105, "Joshitha");
                foreach (var item in pairs)
                {
                    Console.WriteLine(item);
                }
                pairs.Add(106, "Gomu");
                Console.WriteLine("Using the key to access the value " + pairs[103]);
                pairs.Remove(102);
                Console.WriteLine("After removing");
                foreach (var item in pairs)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Printing key and value");
                foreach (var item in pairs.Keys)
                {
                    Console.WriteLine(item + " " + pairs[item]);
                }
                Console.WriteLine("Does the collection contain 104?? " + pairs.ContainsKey(104));
            }
            void UnderstandingSet()
            {
                HashSet<int> set = new HashSet<int>();
                set.Add(10);
                set.Add(3);
                set.Add(345);
                set.Add(10);
                set.Add(4534);
                Console.WriteLine("Does the set conain a 3?? " + set.Contains(3));
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Let's see another set");
                SortedSet<double> sortedSet = new SortedSet<double>();
                foreach (var item in set)
                {
                    sortedSet.Add(item);
                }
                foreach (var item in sortedSet)
                {
                    Console.WriteLine(item);
                }
                SortedSet<Employee> employees = new SortedSet<Employee>();
                employees.Add(new Employee(106, "Kavin", 32423));
                employees.Add(new Employee(105, "Kanav", 2131));
                employees.Add(new Employee(103, "Kayan", 353687));
                Employee empobj = new Employee();
                empobj.TakeEmployeeData();
                foreach (var item in employees)
                {
                    if (item.Equals(empobj))
                        Console.WriteLine(item);
                    else
                        Console.WriteLine("No Matching record found");
                }
            }
            static void Main(string[] args)
            {
                new Program().UnderstandingMoreAboutList();
                Console.ReadKey();
            }
        }

      
    }


