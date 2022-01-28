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
            int[] arrayNumber = new int[30];

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = random.Next(1, 1000);
                Console.Write($"{arrayNumber[i]} ");
            }

            Console.WriteLine("\n\nЛокальные максимумы \n");

            if (arrayNumber[0] > arrayNumber[1])
            {
                Console.WriteLine(arrayNumber[0]);
            }

            for (int i = 1; i < arrayNumber.Length; i++)
            {
                if (arrayNumber.Length - 1 != i)
                {
                    if (arrayNumber[i] > arrayNumber[i - 1] && arrayNumber[i] > arrayNumber[i + 1])
                    {
                        {
                            Console.WriteLine(arrayNumber[i]);
                        }
                    }
                }
            }

            if (arrayNumber[arrayNumber.Length - 1] > arrayNumber[arrayNumber.Length - 2])
            {
                Console.WriteLine(arrayNumber[arrayNumber.Length - 1]);
            }
            Console.ReadKey();
        }
    }
}