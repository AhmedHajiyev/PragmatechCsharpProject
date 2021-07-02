using System;
using System.Linq;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            array = new int[] { 4, 5, 1, 2, 3, };

            Console.WriteLine($"Min-1:{array.Min()}");
            Array.Sort(array);
            Console.WriteLine($"Min-2:{array[0]}");

        }
    }
}
