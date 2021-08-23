using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug13
{
    class Info
    {
        public void display(Student s)
        {
            //Code here to display the details of given student
            Console.WriteLine("{0,-20}{1,-40}{2,-20}", s.Id, s.Name, s.DOB);
                    
        }

        public void display(Course c)
        {
            //Code here to display the details of given course
            Console.WriteLine("{0,-20} {1,-30} {2,-20} {3,-15}",c.CourseId,c.CourseName,c.CourseDuration,c.CourseFees);
        }

        public void display(Enroll e)
        {
            //Code here to display the details of given course
            Console.WriteLine("{0,-20}{1,-40}{2,-20}{3,-30}{4,-20}", e.EnStudent.Id,e.EnStudent.Name,e.EnCourse.CourseId,e.EnCourse.CourseName,e.EnDate);
        }


    }
}
