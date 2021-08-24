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
            Console.WriteLine("ID:{0}\nName:{1}\nDate of Birth:{2}", s.Id, s.Name, s.DOB);
                    
        }

        public void display(Course c)
        {
            //Code here to display the details of given course
            Console.WriteLine("ID:{0}\tCourse:{1}\tDuration:{2}\tFees:{3}",c.CourseId,c.CourseName,c.CourseDuration,c.CourseFees);
        }

        public void display(Enroll e)
        {
            //Code here to display the details of given course
            Console.WriteLine("ID:{0}\tStudent ID:{1}\tStudent Name:{2}\tCourse ID:{3}\tCourse Name:{4}\tEnrollment Date:{5}"
                ,e.EnStudent.Id,e.EnStudent.Name,e.EnCourse.CourseId,e.EnCourse.CourseName,e.EnDate);
        }


    }
}
