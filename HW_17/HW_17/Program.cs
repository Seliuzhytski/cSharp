using HW_17;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

/*1.Написать класс для работы с директориями: 
 * Класс должен содержать методы принимающие путь к папке и возвращающий: 
 * Количество файлов в каталоге, 
 * FileInfo[] файлов из папки, 
 * Класс должен содержать метод принимающие путь к папке и расширение файлов(txt например): 
 * Количество файлов в каталоге, 
 * FileInfo[] файлов из папки.*/
string path = Directory.GetCurrentDirectory();
Console.WriteLine($"Путь до папки: {path}\n");

Console.WriteLine("Задание 1.\n");
var dir = new NumberFilesAndFileInfo();
dir.GetNumberAndInfoFile(path);
dir.GetNumberAndInfoFileByExtension(path, ".cs");

/*2.Создайте в своей папке 20 дочерних директорий с именами MyTestFolder0 MyTestFolder19. Удалите их программо.*/
Console.WriteLine("Задание 2.\n");
if (Directory.Exists(path))
{
    for (int i = 0; i < 20; i++)
    {
        Directory.CreateDirectory($"{path}/MyTestFolder{i}");
    }
    Console.WriteLine("Директории созданы");
}
else
{
    Console.WriteLine("Папки не существует");
}

var directory = new DirectoryInfo(path);
if (directory.Exists)
{
    DirectoryInfo[] directoryInfo = directory.GetDirectories();

    foreach (DirectoryInfo i in directoryInfo)
    {
        if(i.Name.Contains("MyTestFolder"))
        {
            var directory2 = new DirectoryInfo(i.FullName);
            directory2.Delete(true);
        }
    }
    Console.WriteLine("Директории удалены\n");
}
else
{
    Console.WriteLine("Папки не существует");
}

/*3.Создайте любой файл, запишите в него текст  
 * “Привет с первой строки 
 * Привет с 3й строки”, 
 * закройте файл. Прочитайте файл и покажите на консоль.*/
Console.WriteLine("Задание 3.\n");
FileStream stream = new FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

StreamWriter writer = new StreamWriter(stream);

writer.WriteLine("Привет");
writer.Write(writer.NewLine);
writer.WriteLine("Привет");

writer.Close();

StreamReader reader = File.OpenText("Test.txt");
string? input;

Console.WriteLine("Текст из файла:");
while ((input = reader.ReadLine()) != null)
{
    Console.WriteLine(input);
}

reader.Close();
Console.WriteLine();

/*4. Создайте класс MyItem c 2мя public свойствами: Age и Name. 
 * Создайте объект данного типа. 
 * Сериализуйте этот обект в JSON используя Newtonsoft.Json так, 
 * чтобы поле Name не попадало в JSON, а значение Age было в поле JSON с именем MyAge.*/
Console.WriteLine("Задание 4.\n");
var myItem = new MyItem { Name = "Alex", Age = "34" };

string json = JsonConvert.SerializeObject(myItem);
Console.WriteLine(json);



