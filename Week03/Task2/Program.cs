using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"0-10 eded texmin et");
            Console.WriteLine($"I Texmin:");
            int texmin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"II Texmin:");
            int texmin2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"III Texmin:");
            int texmin3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"IV Texmin:");
            int texmin4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"V Texmin:");
            int texmin5 = Convert.ToInt32(Console.ReadLine());




            Random rndm = new Random();
            int randomNumber = rndm.Next(10);
            do
            {

                if (texmin != randomNumber && texmin2 != randomNumber && texmin3 != randomNumber && texmin4 != randomNumber && texmin5 != randomNumber)
                {

                    Console.WriteLine($"Sizin texmin haqqiniz bitmishdir");
                    Console.WriteLine($"Tutulan eded {randomNumber}`di");

                    break;
                }
                Console.WriteLine($"{randomNumber} texmini duzdur");
                break;

            } while (texmin == randomNumber || texmin2 == randomNumber || texmin3 == randomNumber || texmin4 == randomNumber || texmin5 == randomNumber);

            if (texmin > randomNumber || texmin2 > randomNumber || texmin3 > randomNumber || texmin4 > randomNumber || texmin5 > randomNumber)
            {
                Console.WriteLine($"Texmin etdiyiniz eded tutulan ededden boyukdur");

            }
            else if (texmin == randomNumber || texmin2 == randomNumber || texmin3 == randomNumber || texmin4 == randomNumber || texmin5 == randomNumber)
            {
                Console.WriteLine($"Texmin etdiyiniz eded tutulan edede beraberdir");
            }
            else
            {
                Console.WriteLine($"Texmin etdiyiniz ededler tutulan ededden kicikdir");
            }

        }
    }
}
