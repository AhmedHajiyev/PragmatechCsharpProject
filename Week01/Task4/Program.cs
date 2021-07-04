using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin:");
            string surname = Console.ReadLine();
            Console.WriteLine($"Salam, {name} {surname}.");
        }
    }
}
