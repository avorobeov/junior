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
            Dictionary<string, string> talkDictionary = new Dictionary<string, string>();

            string inputUser;
            string queryResults;
            talkDictionary.Add("слово", "Единица языка, служащая длянаименования понятий, предметов, лиц, действий, состояний, признаков,связей, отношений, оценок. Знаменательные и служебные слова. Происхождениеслов. С. в с. (о переводе, пересказе: буквально).");
            talkDictionary.Add("результат", "РЕЗУЛЬТАТ, -а, м. 1. То, что получено в завершение какой-н.деятельности, работы, итог. Результаты исследования. Результаты конкурса. 2.Показатель мастерства (обычно спортивного). Р. пловца. Р. в беге \"а 100м.Улучшить свои результаты.Лучшийр.дня. * В результате чего, предлог с род.п. - вследствие чего - н., из - за чего - н.Ущерб в результате аварии.Пострадалв результате неосторожности.В результате того что, союз(книжн.) - вследствие того что, из - за того что.Всегда опаздывает, в результате тогочто не может рассчитать время.А(и) в результате, в знач.союза - и потому, и вследствие этого.Не рассчитали время, а(и) в результате опоздали.IIприл.результатный, -ая, -ое.");

            bool isExit = false;

            while (isExit == false)
            {
                Console.WriteLine("Для выхода ведите команду Exit");
                Console.WriteLine("Ведите слово для получения его значения:");
                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "Exit":
                        isExit = true;
                        break;
                    default:
                        queryResults = SeekMeaning(talkDictionary, inputUser);
                        Console.WriteLine(queryResults);
                        break;
                }
            }
        }

        static string SeekMeaning(Dictionary<string, string> Dictionary, string querySearch)
        {
            foreach (var item in Dictionary)
            {
                if (item.Key.ToLower() == querySearch.ToLower())
                {
                    return $"Ответ на ваш запрос: {item.Value}";
                }
            }

            return "Такого слова нет в базе: ";
        }


    }
}