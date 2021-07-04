using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"Eded musbetdir.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Eded menfidir.");
            }
            else
            {
                Console.WriteLine($"Eded 0`dir.");
            }
        }
    }
}
