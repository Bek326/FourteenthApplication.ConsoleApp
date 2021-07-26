using System;

namespace FourteenthApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string[] CreateArrayPets(int num)
        {
            var result = new string[num];
            return result;
        }
        static (string Name, string LastName, int Age) EnterUser()
        {
            (string Name, string LastName, int Age) User;
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилия: ");
            User.LastName = Console.ReadLine();
            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами: ");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));
            User.Age = intage;
            return User;
        }
        static bool CkeckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
                {
                    corrnumber = 0;
                    return false;
                }
            }
        }
    }
}
