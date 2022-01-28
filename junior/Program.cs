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
            int[,] arrayNumber = {{1, 2, 3, 6, 55, 66, 77,32,43,43},
                                  {4, 5, 6, 34, 21, 76, 32,43,66,22},
                                  {7, 8, 9,12,24,22,23,432,45,432}};
            int maximumNumber = int.MinValue;
            int numberColumn = 0;
            int numberLine = 0;

            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    Console.Write(arrayNumber[i, j] + " ");
                    if (maximumNumber <= arrayNumber[i, j])
                    {
                        maximumNumber = arrayNumber[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Изменённая матрица");
            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    if (maximumNumber == arrayNumber[i, j])
                    {
                        arrayNumber[i, j] = 0;
                    }
                    Console.Write(arrayNumber[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Самое большое число {maximumNumber}");
            Console.ReadKey();

        }
    }
}