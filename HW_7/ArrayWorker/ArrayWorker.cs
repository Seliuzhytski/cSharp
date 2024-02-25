namespace ArrayWorkerLib
{
    public class ArrayWorker
    {
        public int[] Inversia (int[] array)
        {
            int n = array.Length;
            int k = n / 2;
            int temp;

            for (int i = 0; i < k; i++)
            {
                temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }

            Console.WriteLine("Массив после инверсии:");
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

            return array;
        }
    }
}
