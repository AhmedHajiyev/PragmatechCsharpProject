using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rndm = new Random();
                int random = rndm.Next(100);
                numbers[i] = random;
                sum += random;
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("**********");
            Console.WriteLine(sum);
            Console.WriteLine("**********");
            int[] numbers2;
            numbers2 = new int[5];
            int count = 0;
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rndm = new Random();
                int random2 = rndm.Next(100);
                numbers2[i] = random2;
                Console.WriteLine(numbers2[i]);
                a += numbers2[i];

            }
            Console.WriteLine("**********");
            Console.WriteLine(a);
            Console.WriteLine("**********");
        }
    }
}
