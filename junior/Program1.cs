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
            string userInputPassword;
            string userPasword = "ijunior";
            int countAttempts = 3;
            int attemptsLeft = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ведите пароль для вывода секретного текста: ");
                userInputPassword = Console.ReadLine();

                if (userInputPassword == userPasword)
                {
                    Console.WriteLine("Секретное сообщение \n" +
                                      "Нажмите любую клавишу для закрытия программы ");
                    Console.ReadKey();
                    i = 3;
                }
                else
                {
                    attemptsLeft = countAttempts - i;
                    Console.WriteLine($"Пароль не верный у вас осталось {attemptsLeft} попыток \n");
                }
            }

        }
    }
}
