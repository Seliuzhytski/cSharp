using HW_15;
using System.Threading.Channels;

/*1.Разработать класс School который содержит учеников, и имеет публичный метод, 
который принимает делегат который используется для поиска конкретного ученика по имени и фамилии.
Добавить в школу директора школы, который должен реагировать на добавление нового ученика в школу, 
директор должен получить информацию с именем и возрастом ученика и отправить сообщение с приветствием его родителям.*/

var director = new Director("Александр Сергеевич");
var school = new School(director);

var student1 = new Student("Vasia", "Pupkin", 15);
var student2 = new Student("Galia", "Ivanova", 14);

school.Mes += director.SendMessage;
school.AddStudent(student1);
school.AddStudent(student2);

Predicate<Student> predicate = (s) =>
{
    bool result = false;
    if (s.Name == "Vasia" && s.Surname == "Pupkin")
    {
        result = true;
    }
    return result;
};

var student = school.Search(predicate);

Console.WriteLine(student != null ? "Ученик найден" : "Ученик не найден" );

