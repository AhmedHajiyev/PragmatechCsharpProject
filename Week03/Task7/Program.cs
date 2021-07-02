using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] counter = new int[10];
            Random random = new Random();
            int elem = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int number = random.Next(0, 10);
                if (number == 0)
                {
                    continue;
                }
                elem = Array.IndexOf(arr, number);
                if (elem == -1)
                {
                    arr[i] = number;
                }
                else
                {
                    i--;
                    counter[i] = counter[i] + 1;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Tekrarlanan elementler");
            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine($"{i} ededi  {counter[i]} defe tekrarlanib");
            }
        }
    }
}
