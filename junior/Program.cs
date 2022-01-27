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
            int[,] arrayNumber = { { 1, 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2, 2 } };
            int[] arraySumNumbers = new int[arrayNumber.GetLength(0)];
            int sumNumbers = 0;
            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(1); j++)
                {
                    Console.Write(arrayNumber[i, j]);
                    sumNumbers += arrayNumber[i, j];
                    arraySumNumbers[i] = sumNumbers;
                }
                Console.WriteLine();
                sumNumbers = 0;
            }

            for (int i = 0; i < arraySumNumbers.Length; i++)
            {
                Console.WriteLine($"Сума {i} столбца равняется  {arraySumNumbers[i]}");
            }
            Console.ReadKey();


        }
    }
}
