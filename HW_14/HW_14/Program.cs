using HW_14;
using System.Collections.Generic;
using System.Text;

Console.WriteLine("Задание 1.");
//#1
var shop = new Shop("21vek.by", "Alex");

var good1 = new Good("Телефон Iphone", 2230.30);
var good2 = new Good("Телевизор LG", 3500.35);
var good3 = new Good("Ноутбук Asus", 5890.45);
var good4 = new Good("Планшет Samsung", 1478.10);

shop.AddGood(good1);
shop.AddGood(good2);
shop.AddGood(good3);
shop.AddGood(good4);
//shop.AddGood(good4);

shop.SaleGood(good2, 4500.00);
//shop.ClearShop();
shop.ShowGoods();

Console.WriteLine();

//#2
Console.WriteLine("Задание 2.");

Point:
Console.WriteLine("Введите целое число от 0 до 255");

string? one = Console.ReadLine();
int first;

try
{
    if (one is null)
    {
        throw new Exception("Не задано число");
    }
    else if (int.TryParse(one, out first) == false)
    {
        throw new Exception($"Введенное значение {one} не являтся числом");
    }
    else
    {
        if (first < 0 || first > 255)
                {
            throw new Exception("Число не уложилось в лимит от 0 до 255");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
    goto Point;
}

SecondPoint:
Console.WriteLine("Введите второе целое число от 0 до 255");

string? two = Console.ReadLine();
int second;

try
{
    if (two is null)
    {
        throw new Exception("Не задано второе число");
    }
    else if (int.TryParse(two, out second) == false)
    {
        throw new Exception($"Введенное значение {two} не являтся числом");
    }
    else
    {
        if (second < 0 ||  second > 255)
                {
            throw new Exception("Число не уложилось в лимит от 0 до 255");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
    goto SecondPoint;
}

try
{
    Console.WriteLine($"Результат деления: {first / second}\n");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Деление на ноль невозможно {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка {ex.Message}");
}

//#3
Console.WriteLine("Задание 3.");
try
{
    var person = new Person("");
    Console.WriteLine(person.Name + "\n");
}
catch (CustomStringEmptyExeption ex)
{
    Console.WriteLine($"{ex.Message}");
}

//#4
Console.WriteLine("Задание 4.");
