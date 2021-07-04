using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ci ededi daxil edin:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1ci ededi daxil edin:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} {secondNumber}`dan boyukdur.");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"{firstNumber} {secondNumber}`dan kicikdir.");

            }
            else
            {
                Console.WriteLine($"{firstNumber} {secondNumber}`a beraberdir.");
            }
        }
    }
}
