using System;
using System.Collections;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sport = new ArrayList();
        Returnhere:
            Console.WriteLine("Sport Komplekse Qeydiyyat Sistemi");
            Console.WriteLine("Edeceyiniz emeliyyati secin:");
            Console.WriteLine();
            Console.WriteLine("1-Uzv daxil edin");
            Console.WriteLine("2-Uzvu qeydiyyatdan silin");
            Console.WriteLine("3-Uzvlerin siyahisini gorun");
            Console.WriteLine("4-Uzvlerin siyahini ters cevirin");
            Console.WriteLine("5-Uzvlerin qeydiyyatda olub olmamasini yoxlayin");
            Console.WriteLine("6-Uzvlerin siyahisini bashdan sona siralayin");
            Console.WriteLine("7-Butun uzvlerin qeydiyyatini silin");
            Console.WriteLine("8-Sport komlekse qeydiyyat sisteminden cixin");
            Console.WriteLine();
            int chs = Convert.ToInt32(Console.ReadLine());

            switch (chs)
            {
                case 1:
                    Console.WriteLine("Uzv daxil etme ekranina xosh geldiniz");
                    Console.WriteLine("Nece uzv daxil etmek isteyirsiz?");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{i + 1}. uzvu daxil edin:");
                        string name = Console.ReadLine();
                        sport.Add(name);
                    }
                    Console.WriteLine("Emeliyyat ugurla basa catdi");
                    goto Returnhere;
                case 2:
                    Console.WriteLine("Uzv silme ekranina xosh geldiniz");
                    for (int i = 0; i < sport.Count; i++)
                    {
                        Console.WriteLine("Hansi uzvu silmek isteyirsiz?");
                        string name = Console.ReadLine();
                        sport.Remove(name);
                    }
                    goto Returnhere;
                case 3:
                    Console.WriteLine("Uzv list ekranina xos geldiniz");
                    if(sport.Count == 0)
                    {
                        Console.WriteLine("Uzv yoxdur");
                    }
                    foreach (var uzv in sport)
                    {
                        Console.WriteLine(uzv);
                    }
                    goto Returnhere;
                case 4:
                    Console.WriteLine("Uzv listinin ters gosterilmesi");
                    foreach (var uzv in sport)
                    {
                        Console.WriteLine(uzv);
                    }
                    Console.WriteLine();
                    for (int i = sport.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(sport[i]);
                    }
                    goto Returnhere;
                case 5:
                    Console.WriteLine("Uzv yoxlama ekranina xosh geldiniz");
                    Console.WriteLine("Hansi uzvu yoxlamaq isteyirsiz?");
                    string chk = Console.ReadLine();

                    if (sport.Contains(chk))
                    {
                        Console.WriteLine($"{chk} uzvu sistemimizde movcuddur");
                    }
                    else
                    {
                        Console.WriteLine("Uzv tapilmadi");
                    }
                    goto Returnhere;
                case 6:
                    Console.WriteLine("Uzvlerin siyahisi ekranina xosh geldiniz");
                    sport.Sort();
                    foreach (var uzv in sport)
                    {
                        Console.WriteLine(uzv);
                    }
                    goto Returnhere;
                case 7:
                    Console.WriteLine("Uzv temizleme ekranina xosh geldiniz");
                    sport.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Butun uzvler sistemden silindi");
                    goto Returnhere;
                case 8:
                    break;
            }
        }
    }
}
