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
            string userName;
            string userLastname = "" ;
            string userPassword = "";
            string userInputComand;
            bool isExit = false;

            Console.Write("Добрый день как я могу к вам обращаться: ");
            userName = Console.ReadLine();

            while (isExit == false)
            {
                Console.WriteLine("Список команд \n\n" +
                                  "1) Эта команда предназначена для смены имени  = Rename \n" +
                                  "2) Эта команда предназначена для смены цвета текста на красный = ChangeTxtColorRed \n" +
                                  "3) Эта команда предназначена для смены цвета текста на желтый = ChangeTxtColorYellow \n" +
                                  "4) Эта команда сбрасывает цвет в исходное состояние = ResetЕextСolor \n" +
                                  "5) Эта команда заполняет ваши данные в профиль = FillOutAForm \n" +
                                  "6) Эта команда выводит ваши данные на экран = DisplayingDataOnTheScreen \n" +
                                  "7) Эта команда закроет программу = Exit \n");
                Console.Write("Ведите команду из списка: ");
                userInputComand = Console.ReadLine();

                switch (userInputComand)
                {
                    case "Rename":
                        Console.Write("Ведите новое имя:");
                        userName = Console.ReadLine();
                        Console.WriteLine("Имя успешно изменено");
                        break;
                    case "ChangeTxtColorRed":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "ChangeTxtColorYellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "ResetЕextСolor":
                        Console.ResetColor();
                        break;
                    case "FillOutAForm":
                        Console.Write("Ведите свою фамилию: ");
                        userLastname = Console.ReadLine();
                        Console.Write("Ведите пароль: ");
                        userPassword = Console.ReadLine();
                        break;
                    case "DisplayingDataOnTheScreen":
                        Console.WriteLine($"Ваше имя: {userName} \n" +
                                          $"Ваша фамилия: {userLastname} \n" +
                                          $"Ваш пароль: {userPassword}");
                        break;
                    case "Exit":
                        isExit = true;
                        break;

                }
            }
        }
    }
}
