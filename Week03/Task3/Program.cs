using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Eded daxil et:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                Console.WriteLine($"1");
            int i = n;
            int f = 1;
            while (n / i != n)
            {
                f = f * i;
                i--;
            }
            Console.WriteLine($" {n}! = {f}");

        }
    }
}
