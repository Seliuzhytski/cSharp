using System;
using System.Diagnostics;
using System.Text;
namespace CW_6_1202
{
    internal class Program
    {
        /*  1. Создать метод принимающий массив и строку, 
            2. Метод должен проверить параметры, если они невалидны вернуть null. 
            3. Если валидны, проверить что в массиве есть место и добавить туда значение.
               Если места нет, создать массив большей длинны и добавить туда новое значение.(старые значения тоже сохраняются!). 
               В случае если массив уже содержит данное значение, новое значение не возвращать, вернуть исходный массив(проверка равенства не должна учитывать регистр).
        */
        public static string[] AddValueToArray(string[] array, string value)
        {
            if (array == null || value == null)
                return null;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = value;
                    return array;
                } else if ((string.Equals(array[i], value, StringComparison.OrdinalIgnoreCase)))
                {
                    return array;
                }
            }

            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
            return array;
        }
        static void Main(string[] args)
        {
            string[] array = { "apple", "banana", "GrApe", "tomato", "cucumber" };
            string value = "grape";

            Console.WriteLine("Исходный массив:");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write($"{array[j]} ");
            }
            
            Console.WriteLine(" \n" + "Строка:");
            Console.WriteLine(value);

            var array2 = AddValueToArray(array, value);

            Console.WriteLine("Результат:");
            if (array2 != null)
            {
                for (int j = 0; j < array2.Length; j++)
                    Console.Write($"{array2[j]} ");
            }
            Console.ReadKey();

        }
    }
}

