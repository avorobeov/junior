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
            int countErrorsInputPassword = 0;
            int maximumСountErrorInputPassword = 3;

            for (int i = 0; i < maximumСountErrorInputPassword; i++)
            {
                Console.Write("Ведите пароль для вывода секретного текста: ");
                userInputPassword = Console.ReadLine();

                if (userInputPassword == userPasword)
                {
                    Console.WriteLine("Секретное сообщение \n" +
                                      "Нажмите любую клавишу для закрытия программы ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    countErrorsInputPassword++;
                    Console.WriteLine($"Пароль не верный у вас осталось {maximumСountErrorInputPassword - countErrorsInputPassword} попыток \n");
                }
            }

        }
    }
}
