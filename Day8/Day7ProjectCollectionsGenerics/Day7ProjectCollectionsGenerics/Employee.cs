using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ProjectCollectionsGenerics
{
    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return "ID is " + Id
                + "\nName is " + Name
                + "\nSalary is " + Salary;
        }
        public Employee()
        {
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Employee e1, e2;
            e1 = this;
            e2 = (Employee)obj;
            if (e1.Id == e2.Id && e1.Name == e2.Name && e1.Salary == e2.Salary)
                result = true;
            return result;
        }

        public int CompareTo(Employee other)
        {
            return this.Id.CompareTo(other.Id);
            //return this.Name.CompareTo(other.Name);
            //return this.Salary.CompareTo(other.Salary);
        }

      
       
        public void TakeEmployeeData()
        {
            Console.WriteLine("Please enter the employee ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
