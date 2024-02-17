using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            const double Pi = 3.141592653;

            Console.WriteLine("Введите радиус основания конуса r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение образующeй конуса l:");
            double l = Convert.ToDouble(Console.ReadLine());

            double s = Pi * r * (r + l);

            Console.WriteLine($"Площадь поверхности круглого конуса с радиусом = {r} и образующей = {l} будет = {s}");
            

            //#2
            Console.WriteLine("Введите число:");
            double var = Convert.ToDouble(Console.ReadLine());

            if (var % 2 == 0)
            {
                Console.WriteLine($"Число {var} чётное");
            }
            else
            {
                Console.WriteLine($"Число {var} нечётное");
            }

            //#3
            int x = 14,
                y = 1,
                z = 5;

            x += y - x++ * z;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("_______________________________________");

            z = --x - y * 5;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("_______________________________________");

            y /= x + 5 % z;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("_______________________________________");

            z = x++ + y * 5;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("_______________________________________");

            x = y - x++ * z;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("_______________________________________");

            //#4
            Console.WriteLine(default(int));
            Console.WriteLine(default(string));
            Console.WriteLine(default(char));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(sbyte));
            Console.WriteLine(default(byte));
            Console.WriteLine(default(short));
            Console.WriteLine(default(ushort));
            Console.WriteLine(default(uint));
            Console.WriteLine(default(long));
            Console.WriteLine(default(ulong));
            Console.WriteLine(default(float));
            Console.WriteLine(default(double));
            Console.WriteLine(default(decimal));

            //#5
            double height = 176.2;
            Console.WriteLine(nameof(height));
            Console.WriteLine(height);

        
        }
    }
}
