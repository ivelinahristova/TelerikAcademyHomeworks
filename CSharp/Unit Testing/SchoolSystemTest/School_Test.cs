using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School
{
    [TestClass]
    public class School_Test
    {
        [TestMethod]
        public void School_PushLessThan10Courses()
        {
            
            List<Course> courses = new List<Course>();
            
            for (int j = 0; j < 5; j++)
            {
                List<Student> students = new List<Student>();
                for (int i = 0; i < 5; i++)
                {
                    students.Add(new Student("Rich", 12345));
                }
                courses.Add(new Course(students));
            }
            
            School school = new School(courses);
            Assert.AreEqual(school.Courses.Count, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void School_PushMoreThan10Courses()
        {

            List<Course> courses = new List<Course>();

            for (int j = 0; j < 15; j++)
            {
                List<Student> students = new List<Student>();
                for (int i = 0; i < 5; i++)
                {
                    students.Add(new Student("Rich", 12345));
                }
                courses.Add(new Course(students));
            }

            School school = new School(courses);
            Assert.AreEqual(school.Courses.Count, 15);
        }
    }
}
