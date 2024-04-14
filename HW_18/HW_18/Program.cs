/*1.Одновременное выполнение задач:
Создайте программу, в которой несколько потоков выполняют разные задачи одновременно. 
Например, один поток выводит числа от 1 до 10, а другой - буквы от A до J.*/

using HW_18;
using System.IO;

Console.WriteLine("Задание 1.\n");
Thread myThread = new Thread(Print);
myThread.Start();
 
// действия, выполняемые в главном потоке
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Главный поток: {i}");
    Thread.Sleep(10);
}
 
// действия, выполняемые во втором потоке
void Print()
{
    List<char> alphabet = new List<char>();
    for (int i = 65; i < 75; i++)
    {
        alphabet.Add((char)i);
    }

    for (int i = 0; i < alphabet.Count; i++)
    {
        Console.WriteLine($"Второй поток: {alphabet[i]}");
        Thread.Sleep(20);
    }
}

/*2.Синхронизация потоков:
Напишите программу, в которой несколько потоков изменяют одну и ту же переменную. 
Используйте мьютексы или другие механизмы синхронизации для предотвращения гонок данных.*/

Console.WriteLine("Задание 2.\n");
int x = 0;
Mutex mutexObj = new();

// запускаем пять потоков
for (int i = 1; i < 6; i++)
{
    Thread myThread1 = new(Print1);
    myThread1.Name = $"Поток {i}";
    myThread1.Start();
}

void Print1()
{
    mutexObj.WaitOne();     // приостанавливаем поток до получения мьютекса
    x = 1;
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
        x++;
        Thread.Sleep(100);
    }
    mutexObj.ReleaseMutex();    // освобождаем мьютекс
}

/*3.Использование Parallel.ForEach:
Примените Parallel.ForEach для обработки элементов коллекции параллельно. 
Например, вычислите квадраты всех чисел в списке параллельно.*/

Console.WriteLine("Задание 3.\n");
ParallelLoopResult result = Parallel.ForEach<int>(
       new List<int>() { 1, 3, 5, 8 },
       Square
);
 
void Square(int n)
{
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Console.WriteLine($"Квадрат числа {n} равен {n * n}");
    Thread.Sleep(400);
}

/*4.Файлы:
Создать три файла. В двух должен быть какой-то текст, последний пустой.
Прочитать содержимое первых двух файлов в различных потоках и записать результаты чтения в третий файл так, 
чтобы операции записи не мешали друг другу.*/

var fileWriter = new FileHelper();

var thread1 = new Thread(() => fileWriter.WriteData("first", "1.txt"));
var thread2 = new Thread(() => fileWriter.WriteData("second", "2.txt"));
var thread3 = new Thread(() => fileWriter.WriteData("", "3.txt"));
thread1.Start();
thread2.Start();
thread3.Start();

var paths = new List<string>
{
    "1.txt",
    "2.txt"
};

foreach (var path in paths)
{
    string result1;
    var thread = new Thread(() =>
    {
        result1 = fileWriter.ReadData(path);
        fileWriter.WriteData(result1, "3.txt");
    });

    thread.Start();
}
