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
            int[] arrayEnteredNumbers = new int[1];
            int[] arrayExpander;

            string usersCommand = "";
            int countChar = 0;
            int sumNumbers = 0;
            bool isExit = false;
            bool isNumber;

            while (!isExit)
            {
                Console.WriteLine("Ведите число или команду \n 1)Считает сумму введенных вами чисел (sum) \n 2)Выход из программы (exit) \n 3)Для добавления чисел для подсчёта просто ведите число \n\n\n");
                usersCommand = Console.ReadLine();
                switch (usersCommand)
                {
                    case "sum":
                        foreach (int Number in arrayEnteredNumbers)
                        {
                            sumNumbers += Number;
                        }
                        Console.WriteLine($"Сумма всех чисел {sumNumbers}\n");
                        sumNumbers = 0;
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        foreach (char ch in usersCommand)
                        {
                            if (Char.IsDigit(ch))
                            {
                                countChar++;
                            }
                        }
                        isNumber = usersCommand.Length == countChar;

                        if (isNumber)
                        {

                            arrayExpander = new int[arrayEnteredNumbers.Length + 1];

                            for (int i = 0; i < arrayEnteredNumbers.Length; i++)
                            {
                                arrayExpander[i] = arrayEnteredNumbers[i];
                            }
                       
                            arrayExpander[arrayEnteredNumbers.Length - 1] = Convert.ToInt32(usersCommand);
                            arrayEnteredNumbers = arrayExpander;
                        }
                        else
                        {
                            Console.WriteLine("Введите пожалуйста число\n\n");
                        }
                        countChar = 0;
                        break;
                }
            }
        }
    }
}