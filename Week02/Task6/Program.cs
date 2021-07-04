using System;

namespace Task6
{
    class Program
    {
        struct person
        {
            public string Name;
            public string Surname;
            public int Age;

            public person(string Name, string Surname)
            {
                this.Name = Name;
                this.Surname = Surname;
                Console.WriteLine("Yasiniz: ");
                this.Age = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin: ");
            string surname = Console.ReadLine();

            person person = new person("Ahmed", "Hajiyev");

            if (person.Name == name && person.Surname == surname)
            {
                if (person.Age >= 18)
                {
                    Console.WriteLine("Sizin yasiniz uygundur.");
                }
                else
                {
                    Console.WriteLine("Sizin yasiniz uygun deyil.");
                }
            }
            else
            {
                Console.WriteLine("Ad ve ya soyad yalnisdir.");
            }
        }
    }
}
