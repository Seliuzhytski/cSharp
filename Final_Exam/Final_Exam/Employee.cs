using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    public class Employee : IComparable<Employee>
    {
        public string? name;
        public int age;
        public double salary;

        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary {  get; set; }

        public Employee(string Name, int Age, double Salary)
        {
            name = Name;
            age = Age;
            salary = Salary;
        }

        public virtual void Print ()
        {
            Console.WriteLine($"Информация о сотруднике: Имя: {name}, Возраст: {age}, Зарплата: {salary} BYN");
        }

        public int CompareTo(Employee obj)
        {
            if (this.Salary > obj.Salary)
                return 1;
            if (this.Salary < obj.Salary)
                return -1;
            else
                return 0;
        }
    }
}
