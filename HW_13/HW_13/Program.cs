using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using HW_13;

internal class Program
{
    static void Main(string[] args)
    {
        //#1
        Console.WriteLine("Задание 1.");
        string[] words = { "Alex", "Natali", "Vasili", "Katy", "Petr", "Valeriy" };

        foreach (string i in GetWords(words))
        {
            Console.Write($"Слово: {i} длиной {i.Length} символов");
        }
        Console.WriteLine("\n");

        //#2
        Console.Write("Задание 2.\nРандомные слова из словаря: ");
        foreach (string i in GetMassivWord(5))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        //#3
        var auto = new AutoShopSortableCollection() { new AutoShop("Ford Mondeo", 6), new AutoShop("Tesla Model S", 55), new AutoShop("Kia Sportage", 25) };
       
        // Создадим множество автомобилей
        auto.Add(new AutoShop("Daewoo Nexia", 3));
        auto.Add(new AutoShop("Honda Torneo", 9));
        auto.Add(new AutoShop("Audi R8 Best", 1));

        Console.ReadLine();
    }

    //#1
    public static IEnumerable<string> GetWords(string[] numbers)
    {
        foreach (string result in numbers)
        {
            if (result.Length > 5)
            {
                yield return result;
            }
        }
    }

    //#2
    public static IEnumerable<string> GetMassivWord(int number)
    {

        List<string> result = new List<string>();
        
        var words = new Dictionary<int, string>()
        {
            [1] = "One",
            [2] = "Two",
            [3] = "Three",
            [4] = "Four",
            [5] = "Five",
            [6] = "Six",
            [7] = "Seven",
            [8] = "Eight",
            [9] = "Nine",
            [10] = "Ten",
        };

        for (int i = 0; i < number; i++)
        {
            Random rnd = new Random();
            int j = rnd.Next(1, 10);
            result.Add(words[j]);
        }
        return result;
    }
}

