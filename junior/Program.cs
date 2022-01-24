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
            int countImage = 52;
            int countRow = countImage / 3; ;
            int restImage = countImage % 3;

            Console.WriteLine($"Количество полностью заполненных рядов: {countRow}");
            Console.WriteLine($"Количество картинок сверх нормы: {restImage}");
            Console.ReadLine();
        }
    }
}
