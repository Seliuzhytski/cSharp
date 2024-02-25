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

        //#3
        var MyStack = new Stack<char>();

            MyStack.Push('A');
            MyStack.Push('N');
            MyStack.Push('X');

            Console.WriteLine("Исходный стек: ");
            foreach (char s in MyStack)
                Console.Write(s);
            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}",MyStack.Pop());
            }

            if (MyStack.Count == 0)
                Console.WriteLine("\nСтек пуст!");

            Console.ReadLine();
    }
}
