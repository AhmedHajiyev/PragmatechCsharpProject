using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Soz daxil edin:");

            string word = Console.ReadLine();
            char[] saitSesler = new char[] { 'a', 'i', 'o', 'u', 'e' };
            int i = 0;
            foreach (var item in saitSesler)
            {
                if (word.Contains(item))
                {
                    
                    i++;
                }


            }
            
            Console.WriteLine($"{i} Sait ses var");
        }
    }
}
