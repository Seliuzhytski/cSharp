using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Разработать класс School который содержит учеников, и имеет публичный метод, 
 который принимает делегат который используется для поиска конкретного ученика по имени и фамилии.
Добавить в школу директора школы, который должен реагировать на добавление нового ученика в школу, 
директор должен получить информацию с именем и возрастом ученика и отправить сообщение с приветствием его родителям.*/

namespace HW_15
{
    internal class School
    {
        //part1
        List<Student> students = new List<Student> { new("Jhon", "Lennon"), new("Pol", "Mac'curtny"), new("Ivan", "Petrov") };

        public Student Search(Predicate<Student> predicate)
        {
            foreach (var student in students)
            {
                if (predicate(student)) return student;
            }

            return null;
        }

        /* public Student Search(Predicate<Student> predicate)
             {
                 return students.Find(predicate);
             }*/

        /*public bool Search(Predicate<Student> predicate)
        {
            foreach (var student in students)
            {
                if (predicate(student)) return true;
            }

            return false;
        }*/

        //part2
        public delegate void AddStudentAndSendMessage(Student student);
        public event AddStudentAndSendMessage? Mes;

        public string Director { get; set; }
        public School(Director director)
        {
            Director = director.Name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            Mes?.Invoke(student);
        }
    }
}
