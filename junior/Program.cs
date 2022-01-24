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
            Console.WriteLine("Введите кол-во старушек:");
            int countGrandmas = Convert.ToInt32(Console.ReadLine());
            int queueWaitingTime = 10;
            int waitingInMinutes = (countGrandmas * queueWaitingTime);
            int waitingInHours = waitingInMinutes / 60;
            Console.WriteLine($"Вы должны отстоять в очереди: {waitingInHours} часа и {waitingInMinutes - waitingInHours * 60} минут.");

            Console.ReadKey();
        }
    }
}
