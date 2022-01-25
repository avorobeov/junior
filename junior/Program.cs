using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace junior
{
    class Program
    {

        static void Main(string[] args)
        {
            string userNama;
            string userAge;
            string userWork;

            Console.Write("Ведите ваше имя: ");
            userNama = Console.ReadLine();
            Console.Write("Ведите ваш возраст: ");
            userAge = Console.ReadLine();
            Console.Write("Укажите вашу профессию: ");
            userWork = Console.ReadLine();

            Console.WriteLine($"Вас зовут {userNama} , вам {userAge} год, вы по профессии {userWork}");
            Console.ReadLine();
        }
    }
}
