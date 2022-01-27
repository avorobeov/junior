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
            int[,] arrayNumber = {{1, 2, 3},
                                  {4, 5, 6},
                                  {7, 8, 9}};

            int sumNumbers = 0;
            int firstColumnProduct = 0;

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumber.GetLength(0); j++)
                {
                    Console.Write(arrayNumber[i, j]);
                }
                sumNumbers += arrayNumber[i, 1];

                Console.WriteLine();
            }

            for (int i = 0; i < arrayNumber.GetLength(0) - 1;)
            {
                firstColumnProduct = arrayNumber[i, 0] * arrayNumber[++i, 0];
            }
            Console.WriteLine($"Сума второй строки: {sumNumbers} произведение первого столбца {firstColumnProduct}");
            Console.ReadKey();


        }
    }
}
