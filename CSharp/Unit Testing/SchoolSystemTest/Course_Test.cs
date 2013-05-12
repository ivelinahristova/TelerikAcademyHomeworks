using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School
{
    [TestClass]
    public class Course_Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Course_CountStudents50()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 50; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
        }

        [TestMethod]
        public void Course_CountStudents5()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
            Assert.AreEqual(course.Students.Count, 5);
        }

        [TestMethod]
        public void Course_JoinStudent()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
            course.Join(new Student("Asq", 55555));
            Assert.AreEqual("Asq", course.Students[5].Name);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Course_JoinStudent30()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 29; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
            course.Join(new Student("Asq", 55555));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Course_LeaveStudentDoNotExist()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
            course.Join(new Student("Asq", 55555));
            course.Leave(new Student("Gosho", 66666));
        }

        [TestMethod]
        public void Course_LeaveStudentExist()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student("Rich", 12345));
            }
            Course course = new Course(students);
            Student student = new Student("Asq", 55555);
            course.Join(student);
            course.Leave(student);
            bool isThere = false;
            foreach (var item in course.Students)
            {
                if (item.Name == "Asq")
                {
                    isThere = true;
                }
            }
            Assert.AreEqual(false, isThere);
        }
    }
}
