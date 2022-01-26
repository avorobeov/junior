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

            int numberIncrease = 7;
            int zoomLimits = 98;

            for (int i = numberIncrease; i <= zoomLimits; i += numberIncrease)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
