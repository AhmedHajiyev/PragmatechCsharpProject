using System;

namespace Task5
{
    class Program
    {

        struct Student
        {
            public int Grade;

            public Student(int grade)
            {
                Grade = grade;
            }

        }
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine($"Bali daxil edin:");
            student.Grade = Convert.ToInt32(Console.ReadLine());
            if (student.Grade > 51 && student.Grade < 61)
            {
                Console.WriteLine($"Tebrikler siz E aldiniz");
            }
            if (student.Grade > 61 && student.Grade < 71)
            {
                Console.WriteLine($"Tebrikler siz D aldiniz");
            }
            if (student.Grade > 71 && student.Grade < 81)
            {
                Console.WriteLine($"Tebrikler siz C aldiniz");
            }
            if (student.Grade > 81 && student.Grade < 91)
            {
                Console.WriteLine($"Tebrikler siz D aldiniz");
            }
            if (student.Grade > 91 && student.Grade <= 100)
            {
                Console.WriteLine($"Tebrikler siz D aldiniz");
            }
            else
            {
                Console.WriteLine($"Teessufler, siz kesildiniz");
            }
        }
    }
}
