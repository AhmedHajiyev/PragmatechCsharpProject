using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int index = 0;
            int[] Numbers;
            Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oddNumbers;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int a = Numbers[i];
                Console.WriteLine(a);
                if (a % 2 != 0)
                {
                    index++;
                }
                
            }
            oddNumbers = new int[index];
            Console.WriteLine("*******");
            for(int c = 0; c < Numbers.Length; c++)
            {
                int a = Numbers[c];
                if (a % 2 != 0)
                {

                        oddNumbers[count] = a;
                        count++;

                    
                }

            }
            for (int d = 0; d < index; d++)
            {
                    Console.WriteLine(oddNumbers[d]);
            }
            
        }
    }
}
