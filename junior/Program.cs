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
            string[] userData = new string[0];
            string[] userPosition = new string[0];

            string userInput;

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("          Меню \n" +
                                  "1) Добавить досье\n" +
                                  "2) Вывести все досье\n" +
                                  "3) Удалить досье\n" +
                                  "4) Поиск по фамилии\n" +
                                  "5) Выход");
                userInput = Console.ReadLine();

                Console.Clear();

                switch (Convert.ToInt32(userInput))
                {
                    case 1:
                        Console.Write("Ведите свои данные (Фамилию Имя Отчество): ");
                        userInput = Console.ReadLine();
                        ArrayExpansion(ref userData);
                        userData[userData.Length - 1] = userInput;

                        Console.Write("Ведите должность: ");
                        userInput = Console.ReadLine();
                        ArrayExpansion(ref userPosition);
                        userPosition[userPosition.Length - 1] = userInput;
                        break;
                    case 2:
                        if (userData.Length > 0 && userPosition.Length > 0)
                        {
                            Console.WriteLine("Вывожу все досье");
                            DataOutput(userData, userPosition);
                        }
                        else
                        {
                            WrateError(1);
                        }
                        break;
                    case 3:
                        if (userData.Length > 0 && userPosition.Length > 0)
                        {
                            Console.Write("Ведите номер досье которое  хотите удалить: ");
                            userInput = Console.ReadLine();
                            DossierDeletion(ref userData, Convert.ToInt32(userInput));
                            DossierDeletion(ref userPosition, Convert.ToInt32(userInput));
                        }
                        else
                        {
                            WrateError(1);
                        }
                        break;
                    case 4:
                        if (userData.Length > 0 && userPosition.Length > 0)
                        {
                            int index;
                            Console.Write("Ведите фамилию того человека которого хотите найти:");
                            userInput = Console.ReadLine();

                            index = SearchIndex(userData, userInput);

                            if (index > -1)
                            {
                                DataOutput(userData, userPosition, index);
                            }
                            else
                            {
                                WrateError(2);
                            }
                        }
                        else
                        {
                            WrateError(1);
                        }
                        break;
                    case 5:
                        isExit = true;
                        break;
                }
            }
        }
        static void ArrayExpansion(ref string[] array)
        {
            string[] arrayGrowth = new string[array.Length + 1];

            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    arrayGrowth[i] = array[i];
                }
            }
            array = arrayGrowth;
        }
        static void DataOutput(string[] data, string[] position)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"{i}) {data[i]}-{position[i]}");
            }
        }
        static void DataOutput(string[] data, string[] position, int index)
        {
            Console.WriteLine($"{index}) {data[index]}-{position[index]}");
        }
        static void DossierDeletion(ref string[] dossier, int index)
        {
            string[] reducedArray;
            reducedArray = new string[dossier.Length - 1];
            for (int i = 0; i < dossier.Length; i++)
            {
                if (index != i)
                {
                    if (reducedArray.Length < i)
                    {
                        reducedArray[i] = dossier[i];
                    }
                    else
                    {
                        reducedArray[i - 1] = dossier[i];
                    }
                }
            }
            dossier = reducedArray;
        }
        static int SearchIndex(string[] array, string searchLine)
        {
            for (int i = 0; i < array.Length; i++)
            {
                foreach (string str in array[i].Split(' '))
                {
                    if (searchLine == str)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        static void WrateError(int indexError)
        {
            switch (indexError)
            {
                case 1:
                    Console.WriteLine("Нет досье в базе:");
                    break;
                case 2:
                    Console.WriteLine("Такого пользователя нет в системе: ");
                    break;
            }
        }
    }
}