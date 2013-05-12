using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        public List<Course> Courses
        {
            get;
            private set;
        }

        public School(List<Course> courses)
        {
            if (courses.Count >=10)
            {
                throw new ArgumentOutOfRangeException("Courses should be less than 10!");
            }
            this.Courses = courses;
        }

    }
}
