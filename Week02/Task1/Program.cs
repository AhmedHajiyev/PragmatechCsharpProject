using System;

namespace Task1
{
    class Program
    {
        struct MyStruct
        {
            public string Username;
            public int Password;

            public MyStruct(string Username, int Password)
            {
                this.Username = Username;
                this.Password = Password;
            }
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password daxil edin: ");
            int password = Convert.ToInt32(Console.ReadLine());
            MyStruct user = new MyStruct("ahmedhajiyev", 999999);

            if (user.Username == username && user.Password == password)
            {
                Console.WriteLine("Sayta xos gelmisiniz.");
            }
            else
            {
                Console.WriteLine("Username ve ya Password yalnisdir.");
            }

        }
    }
}
