namespace Module_5
{
    internal class Program
    {

// Метод записывает данные от пользователя в кортеж//

        static (string Name, string LastName, double Age, bool HasPet, string[] PetsNames, string[] favcolors) UserInfo()
        {
            (string Name, string LastName, double Age, bool HasPet, string[] PetsNames, string[] favcolors) User;
            int count;
            string str;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();
            Console.WriteLine("Есть ли у Вас животное? Да/Нет");
            if (Console.ReadLine() == "Да")
            {
                User.HasPet = true;
                do
                {
                    Console.WriteLine("Введите количество питомцев");
                    str = Console.ReadLine();
                } while (IsNumberCheck(str, out count));
                Console.WriteLine("Введите клички питомцев");
                User.PetsNames = PetsN(count);
            }
            else
            {
                User.HasPet = false;
                User.PetsNames = null;
            }
            do
            {
                Console.WriteLine("Введите Ваш возраст");
                str = Console.ReadLine();
            } while (IsNumberCheck(str, out count));
            User.Age = count;
            do
            {
                Console.WriteLine("Введите количество любимых цветов");
                str = Console.ReadLine();
            } while (IsNumberCheck(str, out count));
            User.favcolors = PetsN(count);
            return User;
        }

//Метод проверки корректности введённого числа//

        static bool IsNumberCheck (string read, out int write)
        {
            if (int.TryParse(read, out int result))
            {
                if (result > 0)
                {
                    write = result;
                    return false;
                }
            }
           {
                    write = 0;
                Console.WriteLine("Некорректное число");
                    return true;
            }
        }

//Метод записи кличек питомцев и цветов в массив//

        static string [] PetsN (int CountPets)
        {
            string [] Names = new string[CountPets];
            for (int w = 0; w < CountPets; w++)
            {
                Names[w] = Console.ReadLine();
            }
            return Names;
        }

//Метод выводит данные о пользователе в консоль//

        static void InfoOut (string Name, string LastName, double Age, bool HasPet, string[] PetsNames, string[] favcolors)
        {
            Console.WriteLine("Ваше имя: {0}", Name);
            Console.WriteLine("Ваша фамилия: {0}", LastName);
            Console.WriteLine("Ваш возраст: {0} лет", Age);
            if (HasPet)
            {
                Console.WriteLine("Питомцы есть");
                Console.WriteLine("Клички питомцев:");
                for (int i = 0; i < PetsNames.Length; i++)
                {
                    Console.WriteLine(PetsNames[i]);
                }
            }
            else Console.WriteLine("Питомцев нет");
            Console.WriteLine("Любимые цвета:");
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine(favcolors[i]);
            }

        }

//Метод запуска программы//

        static void Main(string[] args)
        {
            var info = UserInfo();
            InfoOut(info.Name, info.LastName, info.Age, info.HasPet, info.PetsNames, info.favcolors);
            Console.ReadKey();
        }
    }
}