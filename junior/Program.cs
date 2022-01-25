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
            Random random = new Random();
            string userInput;

            while (true)
            {
                Console.WriteLine($"Ваше сгенерированное число: {random.Next(0, 100)}");
               
                userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    break;
                }
            }
        }
    }
}
