using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} cut ededdir.");
            }
            else
            {
                Console.WriteLine($"{number} tek ededdir.");
            }
        }
    }
}
