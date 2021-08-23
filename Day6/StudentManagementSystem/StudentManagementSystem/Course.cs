using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{
    class Course
    {
        string id;
        string name;
        string duration;
        float fees;

        public Course()
        {

        }

        public Course(string id, string name, string duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }

        public string CourseId
        {
            get{ return id; }
            set { id = value; }
        }

        public string CourseName
        {
            get{ return name; }
            set { name = value; }
        }

        public string CourseDuration
        {
            get { return duration; }
            set { duration = value; }
        }

        public float CourseFees
        {
            get{ return fees; }
            set { fees = value; }
        }

    }


}
