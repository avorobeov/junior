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
            int firstColumnProduct = arrayNumber[0, 0];

            for (int i = 0; i < arrayNumber.GetLength(0); i++)
            {
                for (int j = 1; j <= 1; j++)
                {
                    Console.Write(arrayNumber[i, j] + " ");
                    sumNumbers += arrayNumber[i, j];
                }
                Console.WriteLine();
            }

            for (int i = 1; i < arrayNumber.GetLength(0); i++)
            {
                firstColumnProduct *= arrayNumber[i, 0];
                Console.WriteLine();
            }
            Console.WriteLine($"Сума второй строки: {sumNumbers} произведение первого столбца {firstColumnProduct}");
            Console.ReadKey();


        }
    }
}
