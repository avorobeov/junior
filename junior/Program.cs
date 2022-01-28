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
            int[,] numbers = {{6, 2, 3, 4 ,5, 6, 7, 8, 9},
                              {3, 2, 3, 4 ,5, 6, 7, 8, 9},
                              {4, 2, 3, 4 ,5, 6, 7, 8, 9},
                              {3, 2, 3, 4 ,5, 6, 7, 8, 9},
                              {8, 2, 3, 4 ,5, 6, 7, 8, 9}};
            int sumNumbers = 0;
            int firstColumnProduct = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[1, j]);
                sumNumbers += numbers[1, j];
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                firstColumnProduct *= numbers[i, 0];
            }
            Console.WriteLine($"Сума второй строки: {sumNumbers} произведение первого столбца {firstColumnProduct}");
            Console.ReadKey();


        }
    }
}