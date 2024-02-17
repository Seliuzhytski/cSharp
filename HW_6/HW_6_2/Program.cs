using System;
using System.Diagnostics;
using System.Text;
namespace CW_6_1202
{
    internal class Program
    {
        /*  Создать метод сложения 2-ух матриц (двумерных массивов). Метод возвращает новый двумерный массив. */

        public static int[,] sumTwoMatrix(int[,] array1, int[,] array2)
        {
            int rows = array1.GetUpperBound(0) + 1;    // количество строк
            int columns = array1.Length / rows;        // количество столбцов

            int[,] sum = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum[i, j] = array1[i, j] + array2[i, j];
                    Console.Write($"{sum[i, j]} \t");  // \t - Знак табуляции
                }
                Console.WriteLine();
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 4, 8, 6 }, { 2, 3, 4, 3 } };
            int[,] array2 = { { 4, 4, 5, 1 }, { 5, 2, 9, 7 } };
 
            sumTwoMatrix(array1, array2);
        }
    }
}

