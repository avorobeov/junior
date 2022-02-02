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
            Queue<int> shoppingList = new Queue<int>();

            int amountFunds = 0;
            for (int i = 0; i < 100; i++)
            {
                shoppingList.Enqueue(random.Next(50, 1000));
            }

            for (int i = 0; i < shoppingList.Count; i++)
            {
                amountFunds += shoppingList.Dequeue();
                WrateResult(amountFunds, shoppingList.Count);
                Console.ReadKey();
                Console.Clear();
            }

        }
        static void WrateResult(int balance, int countPeopleLine)
        {
            Console.WriteLine($"На вашем счету:{balance}");
            Console.WriteLine($"Количество человек в очереди: {countPeopleLine}");
        }

    }
}