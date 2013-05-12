using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        public List<Student> Students
        {
            get;
            private set;
        }

        public Course(List<Student> students)
        {
            if (students.Count >=30)
            {
                throw new ArgumentOutOfRangeException("Students should be less than 30!");
            }
            this.Students = students;
        }

        public void Join(Student student)
        {
            if (this.Students.Count == 29)
            {
                throw new InvalidOperationException("Course already has 29 students. Joining in is not possible!");
            }
            this.Students.Add(student);
        }

        public void Leave(Student student)
        {
            if (!this.Students.Contains(student))
            {
                throw new ArgumentException("There is no such a student in the course!");
            }
            this.Students.Remove(student);
        }

    }
}
