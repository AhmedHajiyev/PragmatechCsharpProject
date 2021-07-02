using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 100; i++)
            {
                int a = 0;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
