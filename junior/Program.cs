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
            int minutesInAnHour = 60;
            int queueWaitingTime = 10;
            int waitingInHours = (countGrandmas * queueWaitingTime) / minutesInAnHour;
            int waitingInMinutes = (countGrandmas * queueWaitingTime) - waitingInHours * minutesInAnHour;
            Console.WriteLine($"Вы должны отстоять в очереди: {waitingInHours} часа и {waitingInMinutes} минут.");

            Console.ReadKey();
        }
    }
}
