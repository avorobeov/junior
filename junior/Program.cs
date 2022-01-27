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

            string userName;
            string userInputSymbol;
            string nameOutput = "";
            int countCharactersName;
            int rectangleEnlargementX = 3;
            int returnsCursorStartCoordinates = -1;
            bool isEnding = false;

            Console.Write("Ведите, пожалуйста, своё имя: ");
            userName = Console.ReadLine();

            Console.Write("Ведите, пожалуйста, символ:");
            userInputSymbol = Console.ReadLine();

            countCharactersName = userName.Length;

            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i <= countCharactersName + rectangleEnlargementX; i++)
            {
                nameOutput += userInputSymbol;
                if (i == countCharactersName + rectangleEnlargementX && isEnding == false)
                {
                    nameOutput += $"\n{userInputSymbol} {userName} {userInputSymbol} \n";
                    i = returnsCursorStartCoordinates;
                    isEnding = true;
                }
            }
            Console.WriteLine(nameOutput);
            Console.ReadLine();

            for (int i = 0; i <= countCharactersName + rectangleEnlargementX; i++)
            {
                Console.Write(userInputSymbol);
            }

            Console.WriteLine($"\n{userInputSymbol} {userName} {userInputSymbol}");

            for (int i = 0; i <= countCharactersName + rectangleEnlargementX; i++)
            {
                Console.Write(userInputSymbol);
            }

            Console.ReadLine();
        }
    }
}