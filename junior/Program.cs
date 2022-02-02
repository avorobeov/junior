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
            List<int> MemorizeNumbers = new List<int>();
            string inputUser;

            bool isExit = false;

            WriteText(4);

            while (isExit == false)
            {
                WriteText(3);
                inputUser = Console.ReadLine();
                GetCommand(inputUser, ref MemorizeNumbers, ref isExit);


            }
        }
        static void GetCommand(string input, ref List<int> MemorizeNumbers, ref bool isExit)
        {
            switch (input)
            {
                case "sum":
                    int result = CountNumbers(MemorizeNumbers);
                    WriteText(5, result);
                    break;
                case "exit":
                    isExit = true;
                    break;
                default:
                    AddObject(input, ref MemorizeNumbers);
                    break;
            }
        }
        static int CountNumbers(List<int> MemorizeNumbers)
        {
            int result = 0;
            foreach (var item in MemorizeNumbers)
            {
                result += item;
            }
            return result;
        }
        static void AddObject(string input, ref List<int> MemorizeNumbers)
        {
            int result;
            if (ThisNumber(input, out result))
            {
                MemorizeNumbers.Add(result);
                WriteText(1);
            }
            else
            {
                WriteText(2);
            }
        }
        static bool ThisNumber(string str, out int result)
        {
            if (Int32.TryParse(str, out result))
            {
                return true;
            }
            return false;
        }
        static void WriteText(int number, int result = 0)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Число успешно добавлено");
                    break;
                case 2:
                    Console.WriteLine("Это строка не является числом");
                    break;
                case 3:
                    Console.WriteLine("Ведите, пожалуйста, число");
                    break;
                case 4:
                    Console.WriteLine("Для добавления числа в базу ведите его и нажмите Enter \n" +
                                      "Для подсчёта чисел ведите команду sum \n" +
                                      "Для выхода ведите команду Exit");
                    break;
                case 5:
                    Console.WriteLine($"Сума ведённых вами чисел: {result}");
                    break;
            }
        }

    }
}