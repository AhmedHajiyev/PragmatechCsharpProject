using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilk reqemi daxil edin:");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2ci reqemi daxil edin:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            for (int i = firstNum; i < secondNum; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
