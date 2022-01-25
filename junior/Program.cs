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
            float walletRub = 100;
            float walletUsd = 0;
            float walletEur = 0;
            float walletUa = 0;

            float courseUsd = 76;
            float courseEur = 89;
            float courseUa = 2;
            float correncyCount;

            bool isExid = false;
            bool isEnoughMmaney;
            int selectionExchangeCurrency;

            Console.WriteLine("Здравствуйте нашем обменнике вы можете поменять: \n" +
                              "Рубли на доллары для этого нажмите 1 \n" +
                              "Рубли на евро  для этого нажмите 2 \n" +
                              "Рубли на гривны  для этого нажмите 3 \n" +
                              "Для выхода нажмите 4\n\n\n");

            while (isExid == false)
            {
                Console.WriteLine("Ведите какую валюту вы хотите поменять ?");
                selectionExchangeCurrency = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ведите сумму которую хотите обменять: ");
                correncyCount = Convert.ToInt32(Console.ReadLine());
                

                switch (selectionExchangeCurrency)
                {
                    case 1:
                        isEnoughMmaney =  walletRub > (courseUsd * correncyCount);
                        if (isEnoughMmaney)
                        {
                            walletUsd += correncyCount;
                            walletRub -= correncyCount * courseUsd;
                        }
                        else
                        {
                            Console.WriteLine("К сожалению вам не хватает денег");
                        }
                        break;
                    case 2:
                        isEnoughMmaney = walletRub > (courseEur * correncyCount);
                        if (isEnoughMmaney)
                        {
                            walletEur += correncyCount;
                            walletRub -= correncyCount * courseEur;
                        }
                        else
                        {
                            Console.WriteLine("К сожалению вам не хватает денег");
                        }
                        break;
                    case 3:
                        isEnoughMmaney = walletRub > (courseUa * correncyCount);
                        if (isEnoughMmaney)
                        {
                            walletUa += correncyCount;
                            walletRub -= correncyCount * courseUa;
                        }
                        else
                        {
                            Console.WriteLine("К сожалению вам не хватает денег");
                        }

                        break;
                    case 4:
                        isExid = true;
                        break;

                }
                Console.WriteLine($"На вашему кошельку {walletUsd} долларов {walletEur} евро и {walletUa} гривен и {walletRub} рублей");
            }


            Console.ReadLine();
        }
    }
}
