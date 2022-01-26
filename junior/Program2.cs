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
            int userImpactВamage;
            int userSpellsRashamonВamage = 100;
            int userSpellsHuganzakuraВamage = 100;
            int userSpellsDimensionalRift = 250;
            int actuationPointDimensionalRift = 100;
            bool isDamageBlocking = false;
            bool isSpellCast = false;


            bool isSpiritAlive = false;
            int lifeTimeSpirit = 0;
            int increaseLifetimeOfspirit = 2;
            int bamageSpirit = 10;


            int bossHealth;
            int bossImpactВamage;

            int countSpells = 4;
            int minimumAmountHealthUser = 0;
            int minimumAmountHealthBoss = 0;

            Console.Write("Ведите количество боёв: ");
            countFight = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countFight; i++)
            {
                userHealth = random.Next(500, 600);
                userImpactВamage = random.Next(10, 20);

                bossHealth = random.Next(500, 600);
                bossImpactВamage = random.Next(30, 40);

                while (bossHealth > minimumAmountHealthBoss && userHealth > minimumAmountHealthUser)
                {
                    while (!isSpellCast)
                    {
                        switch (random.Next(0, countSpells))
                        {
                            case 1:
                                if (isSpiritAlive == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Я произнёс заклинание  Рашамон  и вызвал духа (-{userSpellsRashamonВamage})");
                                    userHealth -= userSpellsRashamonВamage;
                                    lifeTimeSpirit += increaseLifetimeOfspirit;
                                    isSpellCast = true;
                                }
                                break;
                            case 2:
                                if (isSpiritAlive == true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine($"Я произнёс заклинание  Хуганзакура  и враг получил {userSpellsHuganzakuraВamage} урона");
                                    bossHealth -= userSpellsHuganzakuraВamage;
                                    isSpellCast = true;
                                }
                                break;
                            case 3:
                                if (userHealth <= actuationPointDimensionalRift)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"Я произнёс заклинание  Межпространственный разлом и восстановил {userSpellsDimensionalRift} здоровья и получил не уязвимость на одну атаку");
                                    userHealth += userSpellsDimensionalRift;
                                    isDamageBlocking = true;
                                    isSpellCast = true;
                                }
                                break;
                        }

                    }
                    isSpellCast = false;

                    isSpiritAlive = lifeTimeSpirit > 0;
                    if (isSpiritAlive == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Дух наносит удар");
                        bossHealth -= bamageSpirit;
                        lifeTimeSpirit--;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Я бью врага! Враг получил {userImpactВamage} урона ");
                    bossHealth -= userImpactВamage;

                    if (isDamageBlocking != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Враг наносит мене удар  ! Я получил урон {bossImpactВamage}");
                        userHealth -= bossImpactВamage;
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
