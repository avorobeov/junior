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
            Database database = new Database();

            string inputUser;

            bool isExit = false;

            while (isExit == false)
            {
                ShowMenu();

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        database.TryAddPlayer();
                        break;

                    case "2":
                        database.TryDelitePlayer();
                        break;

                    case "3":
                        database.TryPlayerBlock();
                        break;

                    case "4":
                        database.TryPlayerUnlock();
                        break;

                    case "5":
                        database.ShowPlayers();
                        break;

                    case "6":
                        isExit = true;
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Для создания пользователя нажмите 1 \n" +
                              "Для удаления пользователя нажмите 2 \n" +
                              "Для блокировки пользователя нажмите 3 \n" +
                              "Для разблокировки пользователя нажмите 4 \n" +
                              "Для вывода всех пользователей нажмите  5 \n" +
                              "Для выхода из программы веди 6");
        }
    }

    class Player
    {
        private string _nickname;

        private int _id;

        private bool _isBlocked;

        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        public string Nickname
        {
            get
            {
                return _nickname;
            }
            private set
            {
                _nickname = value;
            }
        }

        public int Level { get; private set; }

        public bool IsBlocked
        {
            get
            {
                return _isBlocked;
            }
            private set
            {
                _isBlocked = value;
            }
        }

        public Player(int id, string nickname, int lavel, bool isBlocked)
        {
            _id = id;
            _nickname = nickname;
            Level = lavel;
            _isBlocked = isBlocked;
        }

        public void Block()
        {
            IsBlocked = true;
        }

        public void Unlock()
        {
            IsBlocked = false;
        }
    }

    class Database
    {
        private List<Player> _players = new List<Player> { };

        public int LastUsedId { get; private set; }

        private void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        private void DeletePlayer(int id)
        {
            Player player;

            if (TryGetPlayer(out player, id))
            {
                _players.Remove(player);

                Console.WriteLine("Пользователь успешно удалён");
            }
        }

        private void Block(int id)
        {
            Player player;

            if (TryGetPlayer(out player, id))
            {
                player.Block();

                Console.WriteLine("Пользователь успешно заблокирован");
            }
        }

        private void Unlock(int id)
        {
            Player player;

            if (TryGetPlayer(out player, id))
            {
                player.Unlock();

                Console.WriteLine("Пользователь успешно разблокирован");
            }
        }

        private bool CheckForUnique(string nickname)
        {
            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Nickname != nickname && nickname != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private int InputValidationInt(string text)
        {
            string inputUser;

            int meaning = 0;

            bool isCorrect = false;

            while (isCorrect == false)
            {
                Console.Write(text);
                inputUser = Console.ReadLine();

                if (Int32.TryParse(inputUser, out meaning))
                {
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Вы вели вместо числа строку");
                }
            }

            return meaning;
        }

        private bool TryGetPlayer(out Player player, int id)
        {
            player = null;

            for (int i = 0; i < _players.Count; i++)
            {
                if (_players[i].Id == id)
                {
                    player = _players[i];
                    return true;
                }
            }

            return false;
        }

        public void ShowPlayers()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                Console.WriteLine($"Порядковый номер {_players[i].Id} Имя пользователя {_players[i].Nickname} Левел {_players[i].Level} Есть ли у пользователя бан {_players[i].IsBlocked} \n");
            }
        }

        public void TryAddPlayer()
        {
            string nickname;
            string inputUser;

            int id;
            int level;

            bool isBlocked;

            Console.Write($"Для создания нового пользователя ведите его имя:");
            nickname = Console.ReadLine();

            id = LastUsedId++;

            level = InputValidationInt("Ведите левел пользователя:");
           
            Console.Write("Заблокирован ли пользователь (true/false)");
            inputUser = Console.ReadLine();

            isBlocked = inputUser == "true";

            if (CheckForUnique(nickname))
            {
                AddPlayer(new Player(id, nickname, level, isBlocked));
            }
            else
            {
                Console.WriteLine("Данные не прошли  проверку на уникальность попробуйте ещё раз");
            }
        }

        public void TryDelitePlayer()
        {
            int id;

            id = InputValidationInt("Ведите порядковый номер пользователя которого хотите удалить:");

            DeletePlayer(id);
        }

        public void TryPlayerBlock()
        {
            int id;

            id = InputValidationInt("Ведите порядковый номер пользователя которого хотите заблокировать:");

            Block(id);
        }

        public void TryPlayerUnlock()
        {
            int id;

            id = InputValidationInt("Ведите порядковый номер пользователя которого хотите разблокировкировать:");

            Unlock(id);
        }
    }
}