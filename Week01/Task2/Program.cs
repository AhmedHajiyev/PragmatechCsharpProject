using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Surname");
            string surname = Console.ReadLine();
            Console.WriteLine($"Age:");
            int age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Universite:");
            string uni = Console.ReadLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Universite: {uni}");
        }
    }
}
