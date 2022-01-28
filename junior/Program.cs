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
            int[,] arrayNumber = new int[10, 10];
            int maximumNumber = int.MinValue;

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    arrayNumber[i, j] = random.Next(0,1000);
                }
            }

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