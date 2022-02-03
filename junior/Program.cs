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
                        int result = SumNumbers(memorizeNumbers);
                        Console.WriteLine($"Сума ведённых вами чисел: {result}");
                        break;
                    case "exit":
                        isExit = true;
                        break;
                    default:
                        AttemptToAdd(inputUser, memorizeNumbers);
                        break;
                }

            }
        }

        static int SumNumbers(List<int> MemorizeNumbers)
        {
            int result = 0;
            foreach (var numbers in MemorizeNumbers)
            {
                result += numbers;
            }
            return result;
        }
        static void AttemptToAdd(string input, List<int> memorizeNumbers)
        {
            int result;
            if (Int32.TryParse(input, out result))
            {
                memorizeNumbers.Add(Convert.ToInt32(input));
                Console.WriteLine("Число успешно добавлено");
            }
            else
            {
                Console.WriteLine("Это строка не является числом");
            }
        }
    }
}