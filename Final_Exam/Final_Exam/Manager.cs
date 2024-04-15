using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Manager : Employee
    {
        public string? department;

        public string? Department {  get; set; }


        public Manager(string Name, int Age, double Salary, string Department) : base(Name, Age, Salary)
        {
            department = Department;
        }

        public override void Print()
        {
            Console.WriteLine($"Информация о сотруднике: Имя: {name}, Возраст: {age}, Зарплата: {salary} BYN, Отдел: {department}");
        }
    }
}
