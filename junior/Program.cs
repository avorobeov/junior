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
            int[] numbers = new int[0];
            string usersCommand = "";
            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Ведите число или команду \n " +
                                  "1)Считает сумму введенных вами чисел (sum) \n " +
                                  "2)Выход из программы (exit) \n " +
                                  "3)Для добавления чисел для подсчёта просто ведите число \n\n\n");

                usersCommand = Console.ReadLine();
                switch (usersCommand)
                {
                    case "sum":
                        int sumNumbers = 0;
                       
                        foreach (int number in numbers)
                        {
                            sumNumbers += number;
                        }
                       
                        Console.WriteLine($"Сумма всех чисел {sumNumbers}\n");
                        sumNumbers = 0;
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        int[] arrayExpander = new int[numbers.Length + 1];

                        if (numbers.Length != 0)
                        {
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                arrayExpander[i] = numbers[i];
                            }
                            arrayExpander[arrayExpander.Length - 1] = Convert.ToInt32(usersCommand);
                            numbers = arrayExpander;
                        }
                        else
                        {
                            arrayExpander[0] = Convert.ToInt32(usersCommand);
                            numbers = arrayExpander;
                        }
                        break;
                }
            }
        }
    }
}