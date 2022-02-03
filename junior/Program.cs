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
            List<int> memorizeNumbers = new List<int>();
            string inputUser;

            bool isExit = false;

            Console.WriteLine("Для добавления числа в базу ведите его и нажмите Enter \n" +
                                      "Для подсчёта чисел ведите команду sum \n" +
                                      "Для выхода ведите команду exit");
            while (isExit == false)
            {
                Console.WriteLine("Ведите, пожалуйста, число");
                inputUser = Console.ReadLine();
                switch (inputUser)
                {
                    case "sum":
                        int result = CountNumbers(memorizeNumbers);
                        Console.WriteLine($"Сума ведённых вами чисел: {result}");
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        AddObject(inputUser, memorizeNumbers);
                        break;
                }

            }
        }

        static int CountNumbers(List<int> MemorizeNumbers)
        {
            int result = 0;
            foreach (var numbers in MemorizeNumbers)
            {
                result += numbers;
            }
            return result;
        }
        static void AddObject(string input,List<int> MemorizeNumbers)
        {
            if (IsNumber(input))
            {
                MemorizeNumbers.Add(Convert.ToInt32(input));
                Console.WriteLine("Число успешно добавлено");
            }
            else
            {
                Console.WriteLine("Это строка не является числом");
            }
        }
        static bool IsNumber(string str)
        {
            int result;
            if (Int32.TryParse(str, out result))
            {
                return true;
            }
            return false;
        }
    }
}