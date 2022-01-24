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
            Console.WriteLine("Ведите начальное количество золота:");
            int countUserGold = Convert.ToInt32(Console.ReadLine());
            int courseOfCrystals = 3;
            int countUserCrystals = 0;
            Console.WriteLine($"Добрый день не хотели бе купить Кристалов по цене 1 Кристал {courseOfCrystals} золотых");
            Console.WriteLine("Для покупки ведите число кристалов:");
            int countPurchaseCrystals = Convert.ToInt32(Console.ReadLine());
            countUserGold -= countPurchaseCrystals * courseOfCrystals;
            countUserCrystals += countPurchaseCrystals;
            Console.WriteLine($"На вашему щиту {countUserCrystals} кристалов\r\n" +
                              $"На вашему щиту {countUserGold} золотых");
            Console.ReadKey();
        }
    }
}
