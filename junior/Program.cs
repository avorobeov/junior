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
            WrateBar(50, 20, 10, 10);
            Console.ReadKey();
        }
        static void WrateBar(int percent,int size, int positionsX, int positionsY, ConsoleColor color = ConsoleColor.Red)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(positionsX, positionsY);
            int fillingPercentage = Convert.ToInt32(((float)size / 100) * percent);
            int emptyCells = size - fillingPercentage;
            Console.Write('[');
            for (int i = 0; i < fillingPercentage; i++)
            {
                Console.Write('#');
            }
            for (int i = 0; i < emptyCells; i++)
            {
                Console.Write('_');
            }
            Console.Write(']');
        }
    }
}