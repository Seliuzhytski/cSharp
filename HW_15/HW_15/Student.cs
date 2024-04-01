using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
