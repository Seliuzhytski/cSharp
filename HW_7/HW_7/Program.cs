using ArrayWorkerLib;
using ConeLib;


class Program
{
    static void Main(string[] args)
    {
        //#1
        int[] inArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < inArray.Length; i++)
        {
            Console.Write($"{inArray[i]} ");
        }
        Console.WriteLine("\n");

        ArrayWorker outArray = new ArrayWorker();
        outArray.Inversia(inArray);

        //#2
        Cone figure = new Cone(3, 5);
        figure.ConeArea();
        figure.ConeFullArea();

    }
}
