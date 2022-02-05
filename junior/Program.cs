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
            List<string> userFullNames = new List<string>();
            List<string> userPosition = new List<string>();
           
            string userInput;
           
            int teamNumber;

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Для добавления досье нажмите 1 \n" +
                                  "Для вывода списка нажмите 2 \n" +
                                  "Для удаления досье нажмите 3 \n" +
                                  "Для выхода нажмите 4 \n");

                userInput = Console.ReadLine();
                Int32.TryParse(userInput, out teamNumber);

                switch (teamNumber)
                {
                    case 1:

                        AddUser(userFullNames, userPosition);

                        break;
                    case 2:

                        ShowData(userFullNames, userPosition);

                        break;
                    case 3:

                        DeleteUser(userFullNames, userPosition);

                        break;
                    case 4:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Введите пожалуйста номер команды которую хотите использовать");
                        break;
                }
            }
        }
        static void AddUser(List<string> userFullNames, List<string> userPosition)
        {
            Console.WriteLine("Ведите (Фамилию Имя Отчество)");
            userFullNames.Add(Console.ReadLine());
            Console.WriteLine("Ведите вашу должность:");
            userPosition.Add(Console.ReadLine());
        }
    
        static void ShowData(List<string> userFullNames, List<string> userPosition)
        {
            for (int i = 0; i < userFullNames.Count; i++)
            {
                Console.WriteLine($"{i}){userFullNames[i]}-{userPosition[i]}");
            }
        }

        static void DeleteUser(List<string> userFullNames, List<string> userPosition)
        {
            string inputUser;
            int index;

            Console.WriteLine("Ведите порядковый номер юзера которого хотите удалить ");
            inputUser = Console.ReadLine();

            if (Int32.TryParse(inputUser, out index))
            {
                if (index <= userFullNames.Count() && index <= userPosition.Count())
                {
                    userFullNames.RemoveAt(index);
                    userPosition.RemoveAt(index);
                    Console.WriteLine("пользователь успешно удалён");
                }
                else
                {
                    Console.WriteLine("пользователя с таким индексом не существует");
                }
            }
        }


    }
}