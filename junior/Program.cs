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
            int countImageRow = 3;
            int countImage = 52;
            int countRow = countImage / countImageRow;
            int restImage = countImage % countImageRow;

            Console.WriteLine($"Количество полностью заполненных рядов: {countRow}");
            Console.WriteLine($"Количество картинок сверх нормы: {restImage}");
            Console.ReadLine();
        }
    }
}
