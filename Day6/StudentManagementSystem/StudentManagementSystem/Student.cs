using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{   

    class Student
    {
        string id;
        string name;
        DateTime dateOfBirth;
        string course;

        public Student()
        {

        }

        public Student(string id, string name, DateTime dateOfBirth)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public Student(string id, string name, DateTime dateOfBirth, string course)
        {
            this.id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.course = course;
        }

        public string Id
        {
          get {return id;}
          set {id = value;}
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DOB
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }


    }
    
}
