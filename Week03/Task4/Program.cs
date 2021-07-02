using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}ci ad: ");
                string name = Console.ReadLine();
                array[i] = name;
            }

            int count = 0;
            Console.WriteLine("Hansi adi secmek isteyirsizŞ");
            string chsName = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chsName)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
