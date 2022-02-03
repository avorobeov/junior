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

            Queue<int> shoppingList = new Queue<int>();

            FillQueue(shoppingList);
            int amountFunds = 0;

            while (shoppingList.Count != 0)
            {
                amountFunds += shoppingList.Dequeue();
                Console.WriteLine($"На вашем счету:{amountFunds}");
                Console.WriteLine($"Количество человек в очереди: {shoppingList.Count}");
                Console.ReadKey();
                Console.Clear();
            }

        }
        static void FillQueue(Queue<int> shoppingList, int purchasePriceMin = 50, int purchasePriceMax = 1000, int numberBuyers = 10)
        {
            Random random = new Random();
            for (int i = 0; i < numberBuyers; i++)
            {
                shoppingList.Enqueue(random.Next(purchasePriceMin, purchasePriceMax));
            }

        }
    }
}