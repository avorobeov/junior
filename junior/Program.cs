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
            int countCharactersName;
            int rectangleEnlargementX = 3;
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
                Console.Write(userInputSymbol);
                if(i == countCharactersName + rectangleEnlargementX && isEnding == false)
                {
                    Console.Write($"\n{userInputSymbol} {userName} {userInputSymbol} \n");
                    i = -1;
                    isEnding = true;
                }
            }
            Console.ReadLine();
        }
    }
}
