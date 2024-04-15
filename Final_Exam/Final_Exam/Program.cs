using Final_Exam;
using System.Reflection.Metadata;
using System;

//#1
Console.WriteLine("#1");
var employee = new Employee("Alex", 34, 2001.01);
var employee2 = new Employee("Sasha", 32, 1002.01);
var employee3 = new Employee("Masha", 33, 6003.01);

employee.Print();
employee2.Print();
employee3.Print();

employee = new Manager("Alex", 34, 3000.01,"бухгалтерия");

List<Employee> sortEmployees = new List<Employee> { employee, employee2, employee3 };
sortEmployees.Sort();

foreach (Employee a in sortEmployees)
    Console.WriteLine(a.Name);

Console.WriteLine();

//#2
Console.WriteLine("#2");
int[] array = [1, 3, 5, 7, 100];
int sum = 0;
GetArraySum(array);

void GetArraySum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    Console.WriteLine($"Cумма чисел в массиве: {sum}");
}

List<int> number = new List<int> { 1, 3, 4, 5, 6, 7, 11, 56, 51, 22, 14 };

var finishNumber = number.Where(x => x % 2 == 0).ToList();

Console.Write($"Последовательность только четных чисел из коллекции: ");
foreach (int t in finishNumber)
{
    Console.Write(t + " ");
}

Console.WriteLine("\n");

//#3
Console.WriteLine("#3");

Division(6, 0);
void Division (int a, int b)
{
    try
    {
        double result = a / b;
        Console.WriteLine($"Результат деления: {result}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Деление на 0 недопустимо!");
    }
}
Console.WriteLine();

//#4
Console.WriteLine("#4");

string path = @"E:\C#\Git\cSharp_HW\Final_Exam\Test.txt";
string newPath = @"E:\C#\Git\cSharp_HW\Final_Exam\Final_Exam\Test.txt";

FileInfo fileInf = new FileInfo(path);

if (fileInf.Exists)
{
    fileInf.CopyTo(newPath);
    Console.WriteLine($"Файл {fileInf.Name} скопирован из {path} в {newPath}");
}

Console.WriteLine();

//#5
Console.WriteLine("#5");

List<int> numbers = new List<int>();

for (int i = 0; i < 1001; i++)
{
    numbers.Add(i);
}

Thread myThread1 = new Thread(GetEvenNumbers);
Thread myThread2 = new Thread(GetOddNumbers);
myThread1.Start();
myThread2.Start();

void GetEvenNumbers ()
{
    foreach (int i in numbers)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
            Thread.Sleep(100);
        }
    }
}

void GetOddNumbers()
{
    foreach (int i in numbers)
    {
        if (i % 2 != 0)
        {
            Console.Write(i + " ");
            Thread.Sleep(200);
        }
    }
}

Console.ReadKey();