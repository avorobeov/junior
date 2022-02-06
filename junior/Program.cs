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
            Knight knight = new Knight();
            knight.ShowInfo();

            Console.ReadLine();
        }

        class Knight
        {
            private int _health;
            private int _armor;
            private int _damage;

            public Knight(int health,int armor,int damage)
            {
                _health = health;
                _armor = armor;
                _damage = damage;
            }
            public Knight()
            {
                _health = 150;
                _armor = 30;
                _damage = 25;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Количество здоровья {_health} \n" +
                                  $"Количество брони {_armor}\n" +
                                  $"Количество урона {_damage}");
            }
        }
    }

}