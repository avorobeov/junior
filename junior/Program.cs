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
            int[,] numbers = new int[10, 10];
            int maximumNumber = int.MinValue;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0,1000);
                }
            }

            Console.WriteLine("Исходная матрица");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                    if (maximumNumber <= numbers[i, j])
                    {
                        maximumNumber = numbers[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Изменённая матрица");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (maximumNumber == numbers[i, j])
                    {
                        numbers[i, j] = 0;
                    }
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Самое большое число {maximumNumber}");
            Console.ReadKey();

        }
    }
}