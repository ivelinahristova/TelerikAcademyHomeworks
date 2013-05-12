using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public int Number
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public Student(string name, int number)
        {
            if (name == string.Empty)
            {
                throw new ArgumentOutOfRangeException("Name should not be empty");
            }
            if (number < 10000)
            {
                throw new ArgumentOutOfRangeException("Number should be bigger than 10000");
            }
            if (number > 99999)
            {
                throw new ArgumentOutOfRangeException("Number should be smaller than 99999");
            }
            this.Name = name;
            this.Number = number;
        }

    }
}
