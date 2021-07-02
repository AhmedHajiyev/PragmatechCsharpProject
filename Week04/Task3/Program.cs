using System;
using System.Collections;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] birinci = { 5, 4, 3, 2, 1 };
            int[] ikinci = { 7, 4, 3, 1, 8 };
            int counter = 0;
            ArrayList duplicate = new ArrayList();

            for (int i = 0; i < birinci.Length; i++)
            {
                for (int j = 0; j < ikinci.Length; j++)
                {
                    if (birinci[i] == ikinci[j])
                    {
                        counter++;

                        if (!duplicate.Contains(birinci[i]))
                        {
                            duplicate.Add(birinci[i]);
                        }
                    }
                }
            }

            foreach (var item in duplicate)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**");
            Console.WriteLine(counter);
        }
    }
}
