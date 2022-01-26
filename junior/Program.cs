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
            int rectangleEnlargement = 1;
            bool isEnding = false;

            Console.Write("Ведите, пожалуйста, своё имя: ");
            userName = Console.ReadLine();

            Console.Write("Ведите, пожалуйста, символ:");
            userInputSymbol = Console.ReadLine();

            countCharactersName = userName.Length;

            Console.WriteLine("\n\n\n");
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i <= countCharactersName + rectangleEnlargement; i++)
            {
                Console.Write(userInputSymbol);
                if(i == countCharactersName + rectangleEnlargement && isEnding == false)
                {
                    Console.Write($"\n{userInputSymbol + userName + userInputSymbol} \n");
                    i = -1;
                    isEnding = true;
                }
            }
            Console.ReadLine();
        }
    }
}
