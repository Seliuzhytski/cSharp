using System.Linq;
using HW_16;

/*1. Дана целочисленная последовательность [-10, 22, 13, 43, -5, -12, 100]. Извлечь из нее все четные отрицательные числа, 
 * поменяв порядок извлеченных чисел на обратный.*/

Console.WriteLine("Задание 1.");
int[] numbers = [-10, 22, 13, 43, -5, -12, 100];

var selectedNumbers = numbers.Reverse().Where(x => x < 0 && x % 2 == 0);

foreach (var item in selectedNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine();

/*2. Дана последовательность непустых строк A. ["Hello", "here", "we", "are"]. 
 * Получить последовательность символов, каждый элемент которой является начальным символом соответствующей строки из A. 
 * Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.*/

Console.WriteLine("Задание 2.");
string[] words = ["Hello", "here", "we", "are"];

var newWordsArray = words.Select(x => x[0]).Reverse().ToArray();

foreach (var item in newWordsArray)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

/*3*. Дана последовательность-> [11,-20,-5,4,5,8,-1,9,2,0,-11,15,3,-3,4,0,20]
a) Извлечь из нее все положительные числа, сохранив их исходный порядок следования. 
b) Извлечь из нее все нечетные числа, сохранив их исходный порядок следования и удалив все вхождения повторяющихся элементов, кроме первых.
c) Извлечь из нее все четные отрицательные числа, поменяв порядок извлеченных чисел на обратный.
d) Извлечь из нее все положительные двузначные числа, отсортировав их по возрастанию*/

Console.WriteLine("Задание 3.");
int[] num = [11, -20, -5, 4, 5, 8, -1, 9, 2, 0, -11, 15, 3, -3, 4, 0, 20, -5, -5, 11, 5, -32, -10];

var newNumListA = num.Where(x => x > 0);
var newNumListB = num.Where(x => x % 2 != 0).Distinct();
var newNumListC = num.Where(x => x % 2 == 0 && x < 0).Reverse();
var newNumListD = num.Where(x => x > 0 && x > 9).Order();

Console.Write("A: ");
foreach (var item in newNumListA) Console.Write($"{item} ");
Console.Write("\n" + "B: ");
foreach (var item in newNumListB) Console.Write($"{item} ");
Console.Write("\n" + "C: ");
foreach (var item in newNumListC) Console.Write($"{item} ");
Console.Write("\n" + "D: ");
foreach (var item in newNumListD) Console.Write($"{item} ");
Console.WriteLine("\n");

/*4. Исходная последовательность содержит сведения о клиентах фитнес-центра. 
 * Каждый элемент последовательности включает следующие целочисленные поля: 
 * < Год > < Номер месяца > < Продолжительность занятий (в часах) > < Код клиента > 
 * Определить год, в котором суммарная продолжительность занятий всех клиентов была наибольшей, 
 * и вывести этот год и наибольшую суммарную продолжительность. 
 * Если таких годов было несколько, то вывести наименьший из них.*/

Console.WriteLine("Задание 4.");
var clients = new List<Client>
{
    new Client {Id = 7, Year = 2024, Month = 07, TrainingTime = 5 },
    new Client {Id = 8, Year = 2024, Month = 08, TrainingTime = 10 },
    new Client {Id = 9, Year = 2024, Month = 09, TrainingTime = 15 },

    new Client {Id = 1, Year = 2022, Month = 01, TrainingTime = 5 },
    new Client {Id = 2, Year = 2022, Month = 02, TrainingTime = 10 },
    new Client {Id = 3, Year = 2022, Month = 03, TrainingTime = 15 },

    new Client {Id = 4, Year = 2023, Month = 04, TrainingTime = 3 },
    new Client {Id = 5, Year = 2023, Month = 05, TrainingTime = 6 },
    new Client {Id = 6, Year = 2023, Month = 06, TrainingTime = 9 },

    new Client {Id = 7, Year = 2021, Month = 07, TrainingTime = 5 },
    new Client {Id = 8, Year = 2021, Month = 08, TrainingTime = 10 },
    new Client {Id = 9, Year = 2021, Month = 09, TrainingTime = 15 },
};

var newClients = clients.GroupBy(x => x.Year).Select(x => new { Year = x.Key, TrainingTime = x.Sum(x => x.TrainingTime)})
    .OrderBy(x => x.Year).ToList().MaxBy(x => x.TrainingTime);

Console.WriteLine($"Наибольшая суммарная продолжительность занятий была в {newClients.Year} году " +
    $"и составила {newClients.TrainingTime} часов");

Console.WriteLine();

/*5. Создать свой метод LINQ, Median, метод должен быть методом расширения, 
 * и он должен возвращать элемент перечисления находящийся в середине.*/
Console.WriteLine("Задание 5.");
List<int> numberList = [-10, 22, 13, 43, -5, -12, 7];

int i = numberList.Median();
Console.WriteLine($"Элемент перечисления, находящийся в середине - { i }");


/*6*.Создайте две коллекции: List<Car> cars(содержит тип Car, который имеет поля: Id, Name, Age) и List<Buyer> buyers (содержит модель Buyer с полями: Id, Name, CarId). Выведите на консоль информацию об одном покупателе и информацию о машине, которую он купил. Правило выбора покупателя говорит о том, что его имя должно быть первым при сортировке по возрастанию. Один покупатель может купить одну машину.
Один покупатель может купить много машин. 

7*.https://www.linqpad.net/Download.aspx

Samples chapter 8-9

8*.https://viduus.net/wp-content/uploads/2018/02/Rihter-Dzh.-CLR-via-C.-Programmirovanie-na-platforme-Microsoft-.NET-Framework-4.5-na-yazyke-C-Master-klass-2013.pdf
Почитать про События и делегаты*/