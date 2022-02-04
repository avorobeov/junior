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
            int userInput;

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Для добавления досье нажмите 1 \n" +
                                  "Для вывода списка нажмите 2 \n" +
                                  "Для удаления досье нажмите 3 \n" +
                                  "Для выхода нажмите 4 \n");
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AddBase(userData, position);
                        break;
                    case 2:
                        WrateLine(userData, position);
                        break;
                    case 3:
                        Console.WriteLine("Ведите порядковый номер юзера которого хотите удалить ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        ClearUser(userData, position, userInput);
                        break;
                    case 4:
                        isExit = true;
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
        static void WrateLine(List<string> userData, List<string> position)
        {
            for (int i = 0; i < userData.Count; i++)
            {
                Console.WriteLine($"{i}){userData[i]}-{position[i]}");
            }
        }
        static void ClearUser(List<string> userData, List<string> position, int index)
        {
            userData.RemoveAt(index);
            position.RemoveAt(index);
        }
       
        
    }
}