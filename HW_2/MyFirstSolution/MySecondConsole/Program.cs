using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#2
            const decimal Pi = 3.141592653m;
            const decimal E = 1.414213562373095048m;         
            Console.WriteLine(Pi);
            Console.WriteLine(E);

            //#3
            int a = 3;
            byte b = Convert.ToByte(a);
            Console.WriteLine(b);

            //#4
            Console.WriteLine("Введите 1-ое число");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2-ое число");
            double var2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 3-ое число");
            double var3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое 3-ёх введённых чисел: {(var1 + var2 + var3) / 3}");

        }
    }
}
