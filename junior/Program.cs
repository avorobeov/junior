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
            int countConclusions;
            string textMessage;

            Console.WriteLine("Укажите сколько раз вывести вам сообщение: ");
            countConclusions = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите текст сообщения: ");
            textMessage = Console.ReadLine();

            Console.Clear();

            for (int i = 1; i <= countConclusions; i++)
            {
                Console.WriteLine($"{i}) {textMessage}");
            }

            Console.ReadLine();
        }
    }
}
