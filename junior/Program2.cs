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
            int[] arrayNumber = {12,43,35,30,34,23,23,65,67,98,54,34,56,335,45,34,23,45,56,54,12,45,76,34,98,14,67,45,43,56};
            int indexBeforeCastElement = arrayNumber.Length -1;

            bool isLocalMaximumСheck = false;
         
            for (int i = 1; i < arrayNumber.Length; i++)
            {
                if (indexBeforeCastElement != i)
                {
                    isLocalMaximumСheck = arrayNumber[i] > arrayNumber[i - 1] && arrayNumber[i] > arrayNumber[i + 1];
                    if (isLocalMaximumСheck)
                    {
                      Console.WriteLine(arrayNumber[i]);
                    }
                    isLocalMaximumСheck = false;
                }
                else if (indexBeforeCastElement == i)
                {
                    isLocalMaximumСheck = arrayNumber[i] > arrayNumber[i - 1];
                    if (isLocalMaximumСheck)
                    {
                        Console.WriteLine(arrayNumber[i]);
                    }
                    isLocalMaximumСheck = false;
                }
            }

        }
    }
}