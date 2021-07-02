using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastnumbers = 0;
            while (true)
            {

                Console.WriteLine($"Eded daxil edin: ");


                int number = Convert.ToInt32(Console.ReadLine());
                lastnumbers += number;
                if (number == 0)
                {

                    Console.WriteLine($"Cem: {lastnumbers}");
                }
                do
                {
                    if (number == 0)
                    {
                        break;
                    }
                    Console.WriteLine(number);
                    number--;

                } while (number > 0);


            }
        }
    }
}
