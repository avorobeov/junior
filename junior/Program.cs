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
            List<string> userData = new List<string>();
            List<string> position = new List<string>();
           
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
                AttemptConvert(userInput, out teamNumber);

                switch (teamNumber)
                {
                    case 1:

                        AddBase(userData, position);

                        break;
                    case 2:

                        ShowData(userData, position);

                        break;
                    case 3:

                        DeleteUser(userData, position);

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
        static void AddBase(List<string> userData, List<string> position)
        {
            Console.WriteLine("Ведите (Фамилию Имя Отчество)");
            userData.Add(Console.ReadLine());
            Console.WriteLine("Ведите вашу должность:");
            position.Add(Console.ReadLine());
        }
        static void ShowData(List<string> userData, List<string> position)
        {
            for (int i = 0; i < userData.Count; i++)
            {
                Console.WriteLine($"{i}){userData[i]}-{position[i]}");
            }
        }
        static bool AttemptConvert(string input, out int rezult)
        {

            if(Int32.TryParse(input, out rezult))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void DeleteUser(List<string> userData, List<string> position)
        {
            string inputUser;
            int index;
            Console.WriteLine("Ведите порядковый номер юзера которого хотите удалить ");
            inputUser = Console.ReadLine();
            if(AttemptConvert(inputUser, out index))
            {
                userData.RemoveAt(index);
                position.RemoveAt(index);
                Console.WriteLine("пользователь успешно удалён");
            }
            else
            {
                Console.WriteLine("пользователя с таким индексом не существует");
            }
        }


    }
}