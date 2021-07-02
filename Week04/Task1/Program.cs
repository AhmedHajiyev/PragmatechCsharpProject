using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int num = rand.Next(1, 10);
                if (array.Contains(num))
                {
                    i--;
                }
                else
                {
                    array[i] = num;
                }
            }
            for(int i=0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
                Console.WriteLine("******");

            Array.Reverse(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
