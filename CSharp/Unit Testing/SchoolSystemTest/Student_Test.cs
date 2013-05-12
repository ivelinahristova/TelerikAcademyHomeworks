using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
namespace School
{
    [TestClass]
    public class Student_Test
    {
        [TestMethod]
        public void Student_TestName()
        {
            Student student = new Student("Ivan", 11111);
            Assert.AreEqual(student.Name, "Ivan");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_TestNameEmpty()
        {
            Student student = new Student("", 11111);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_TestNumber100IsOutOfRange()
        {
            Student student = new Student("Sara", 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_TestNumber100001IsOutOfRange()
        {
            Student student = new Student("Sara", 100001);
        }

    }
}
