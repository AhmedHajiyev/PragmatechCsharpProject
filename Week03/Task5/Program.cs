using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin:");
            int num;
            string name;
            int pos = 0;

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    break;
                }
                Console.WriteLine("Zehmet olmasa cut reqem daxil edin:");

            } while (num % 2 != 0);

            string[] first = new string[num];
            for (int i = 0; i < first.Length; i++)
            {
                Console.WriteLine($"{i + 1}ci adi daxil edin:");
                name = Console.ReadLine();

                pos = Array.IndexOf(first, name);

                if (pos == -1)
                {
                    first[i] = name;
                }
                else
                {
                    Console.WriteLine("Bu ad artiq daxil edilib,bashqa ad daxil edin.");
                    i--;
                }
            }
        }
    }
}
