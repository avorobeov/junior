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
            List<string> fullNames = new List<string>();
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

                Int32.TryParse(userInput, out teamNumber);

                switch (teamNumber)
                {
                    case 1:

                        AddUser(fullNames, position);

                        break;
                    case 2:

                        ShowData(fullNames, position);

                        break;
                    case 3:

                        DeleteUser(fullNames, position);

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
        static void AddUser(List<string> fullNames, List<string> position)
        {
            Console.WriteLine("Ведите (Фамилию Имя Отчество)");
            fullNames.Add(Console.ReadLine());
            Console.WriteLine("Ведите вашу должность:");
            position.Add(Console.ReadLine());
        }
    
        static void ShowData(List<string> fullNames, List<string> position)
        {

            for (int i = 0; i < fullNames.Count; i++)
            {
                Console.WriteLine($"{i}){fullNames[i]}-{position[i]}");
            }

        }

        static void DeleteUser(List<string> fullNames, List<string> position)
        {
            string inputUser;
            int index;

            Console.WriteLine("Ведите порядковый номер юзера которого хотите удалить ");
            inputUser = Console.ReadLine();

            if (Int32.TryParse(inputUser, out index))
            {
                if (fullNames.Count() >= index && position.Count() >= index)
                {
                    fullNames.RemoveAt(index);
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
}