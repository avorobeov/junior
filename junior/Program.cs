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

            shoppingList = FillQueue(shoppingList);
            int amountFunds = 0;

            while (shoppingList.Count != 0)
            {
                CountPurchases(ref amountFunds, shoppingList);
                WrateResult(amountFunds, shoppingList.Count);
            }

        }
        static Queue<int> FillQueue(Queue<int> shoppingList, int purchasePriceMin = 50, int purchasePriceMax = 1000, int numberBuyers = 10)
        {
            Random random = new Random();
            for (int i = 0; i < numberBuyers; i++)
            {
                shoppingList.Enqueue(random.Next(purchasePriceMin, purchasePriceMax));
            }
            return shoppingList;

        }
        static void CountPurchases(ref int amountFunds, Queue<int> shoppingList)
        {
            amountFunds += shoppingList.Dequeue();
        }
        static void WrateResult(int balance, int countPeopleLine)
        {
            Console.WriteLine($"На вашем счету:{balance}");
            Console.WriteLine($"Количество человек в очереди: {countPeopleLine}");
            Console.ReadKey();
            Console.Clear();
        }

    }
}