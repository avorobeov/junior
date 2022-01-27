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
            int countFight = 0;
            int countPlayerWin = 0;
            int countBossWin = 0;
            int countDraw = 0;


            int userHealth;
            int userImpactDamage;
            int userSpellsRashamonDamage;
            int userSpellsHuganzakuraDamage;
            int userSpellsDimensionalRift;
            int actuationPointDimensionalRift;
            bool isDamageBlocking = false;
            bool isUserSpellCast = false;


            bool isSpiritAlive = false;
            int lifeTimeSpirit = 0;
            int increaseLifetimeOfspirit = 2;
            int bamageSpirit = 10;


            int bossHealth;
            int bossImpactDamage;

            int countSpells = 4;
            int minimumAmountHealthUser = 0;
            int minimumAmountHealthBoss = 0;

            Console.Write("Ведите количество боёв: ");
            countFight = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countFight; i++)
            {
                userHealth = random.Next(500, 600);
                userImpactDamage = random.Next(10, 20);
                userSpellsRashamonDamage = random.Next(70, 111);
                userSpellsHuganzakuraDamage = random.Next(50, 101);
                userSpellsDimensionalRift = random.Next(151, 261);
                actuationPointDimensionalRift = random.Next(70, 101);

                increaseLifetimeOfspirit = random.Next(1, 5);
                bamageSpirit = random.Next(5, 13); ;

                bossHealth = random.Next(500, 600);
                bossImpactDamage = random.Next(30, 40);

                while (bossHealth > minimumAmountHealthBoss && userHealth > minimumAmountHealthUser)
                {
                    while (!isUserSpellCast)
                    {
                        switch (random.Next(0, countSpells))
                        {
                            case 1:
                                if (isSpiritAlive == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Я произнёс заклинание  Рашамон  и вызвал духа (-{userSpellsRashamonDamage})");
                                    userHealth -= userSpellsRashamonDamage;
                                    lifeTimeSpirit += increaseLifetimeOfspirit;
                                    isUserSpellCast = true;
                                }
                                break;
                            case 2:
                                if (isSpiritAlive == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine($"Я произнёс заклинание  Хуганзакура  и враг получил {userSpellsHuganzakuraDamage} урона");
                                    bossHealth -= userSpellsHuganzakuraDamage;
                                    isUserSpellCast = true;
                                }
                                break;
                            case 3:
                                if (userHealth <= actuationPointDimensionalRift)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Я произнёс заклинание  Межпространственный разлом и восстановил {userSpellsDimensionalRift} здоровья и получил не уязвимость на одну атаку");
                                    userHealth += userSpellsDimensionalRift;
                                    isDamageBlocking = true;
                                    isUserSpellCast = true;
                                }
                                break;
                        }

                    }
                    isUserSpellCast = false;

                    isSpiritAlive = lifeTimeSpirit > 0;
                    if (isSpiritAlive == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Дух наносит удар");
                        bossHealth -= bamageSpirit;
                        lifeTimeSpirit--;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Я бью врага! Враг получил {userImpactDamage} урона ");
                    bossHealth -= userImpactDamage;

                    if (isDamageBlocking != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Враг наносит мене удар  ! Я получил урон {bossImpactDamage}");
                        userHealth -= bossImpactDamage;
                    }
                    isDamageBlocking = false;
                }
                if (userHealth <= minimumAmountHealthUser && bossHealth <= minimumAmountHealthBoss)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Оба героя пали в этом бою");
                    countDraw++;
                }
                else if (userHealth <= minimumAmountHealthUser)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Герой проиграл босс, одержал победу");
                    countBossWin++;
                }
                else if (bossHealth <= minimumAmountHealthBoss)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Я выиграл босс, потерпел поражение");
                    countPlayerWin++;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Количество побет героя: {countPlayerWin} \n" +
                              $"Количество побет босса:{countBossWin} \n" +
                              $"Количество ничей: {countDraw}");
            Console.ReadLine();
        }
    }
}
