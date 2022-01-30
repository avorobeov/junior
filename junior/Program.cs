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
            string userInput;
            int numberСonverted =0;

            bool isExit = false;
            bool isNumber;

            while (isExit  == false)
            {
                Console.Write("Ведите число для конвертации:");
                userInput = Console.ReadLine();

                isNumber = ConvertNumber(userInput, ref numberСonverted);

                if (isNumber)
                {
                    Console.WriteLine($"Строку получилось конвертировать вот её значение {numberСonverted}");
                    isExit = true;
                }
                else
                {
                    Console.WriteLine("Конвертация не удалось вести строку ещё раз");
                }
            }
            Console.ReadLine();
        }
        static bool ConvertNumber(string inputString, ref int outputNumber )
        {
            int number;
            bool isNumber;

            isNumber = int.TryParse(inputString, out number);
          
            if (isNumber)
            {
                outputNumber = number;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}