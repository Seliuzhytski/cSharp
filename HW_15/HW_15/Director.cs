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
    internal class Director
    {
        public string? Name { get; set; }
        public Director(string? name)
        {
            Name = name;
        }

        public void SendMessage(Student student)
        {
            Console.WriteLine($"Добрый день, дорогие родители! Меня зовут {Name}, я директор школы. " +
                $"Уведомляю Вас, что Ваш ребёнок {student.Name} {student.Surname}, {student.Age} лет" +
                $" - принят(a) в школу! Сразу сдайте деньги на шторы. Спасибо!\n");
        }
    }
}
