using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Задание 1.");
            int i = 200;
            while (i < 500)
            {
                if (i % 17 == 0) Console.Write($"{i}, ");
                i++;
            }
            Console.WriteLine(" \n");

            //#2
            Console.WriteLine("Задание 2.");
            Console.WriteLine("Введите символ: ");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "W": Console.WriteLine("Двигаемся вверх"); break;
                case "S": Console.WriteLine("Двигаемся вниз"); break;
                case "A": Console.WriteLine("Двигаемся влево"); break;
                case "D": Console.WriteLine("Двигаемся вправо"); break;
                case "w": Console.WriteLine("Двигаемся вверх"); break;
                case "s": Console.WriteLine("Двигаемся вниз"); break;
                case "a": Console.WriteLine("Двигаемся влево"); break;
                case "d": Console.WriteLine("Двигаемся вправо"); break;
                default: Console.WriteLine("Необходимость перемещения отсутствует"); break;
            }
            Console.WriteLine(" \n");

            //#3
            Console.WriteLine("Задание 3.");
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];
            int counter = 0;
            Random rand = new Random();

        Label2:
            array1[counter] = rand.Next(-100, 100);
            Console.WriteLine(array1[counter]);
            counter++;
            if (counter < n)
                goto Label2;
            Console.WriteLine(" \n");

            //#4
            Console.WriteLine("Задание 4.");
            Console.WriteLine("Введите доход: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите ставку налога в процентах: ");
            decimal tax = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Нужно уплатить налог в размере {Nalog(salary, tax)} BYN");

            decimal Nalog(decimal fullsum, decimal stavka)
            {
                return fullsum * stavka / 100;
            }
            Console.ReadKey();
        }
    }
}
