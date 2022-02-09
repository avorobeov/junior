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
        private string _userName;

        private int _id;
        private int _level;

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

        public string UserName
        {
            get
            {
                return _userName;
            }
            private set
            {
                _userName = value;
            }
        }

        public int Level
        {
            get
            {
                return _level;
            }
            private set
            {
                _level = value;
            }
        }

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

        public Player(int id, string username, int lavel, bool isBlocked)
        {
            _id = id;
            _userName = username;
            _level = lavel;
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
        private Player[] _players = new Player[0];

        public int Autoincrement { get; private set; }

        private bool AddPlayer(Player player)
        {
            Player[] expandArray = new Player[_players.Length + 1];

            for (int i = 0; i < _players.Length; i++)
            {
                expandArray[i] = _players[i];
            }

            expandArray[expandArray.Length - 1] = player;

            _players = expandArray;

            return true;
        }

        private void DeletePlayer(int id)
        {
            Player[] expandArray = new Player[_players.Length - 1];

            bool isDelete = false;

            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Id != id)
                {
                    if (isDelete == false)
                    {
                        expandArray[i] = _players[i];
                    }
                    else
                    {
                        expandArray[i - 1] = _players[i];
                    }
                }
                else
                {
                    isDelete = true;
                }
            }

            _players = expandArray;
        }

        private void Block(int id)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if(_players[i].Id == id)
                {
                    _players[i].Block();
                }
            }
        }

        private void Unlock(int id)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Id == id)
                {
                    _players[i].Unlock();
                }
            }
        }

        private bool CheckForUnique(string userName)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].UserName != userName && userName != "")
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

        private bool IsThereIndex(int id, string text)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Id == id)
                {
                    Console.WriteLine(text);
                    return true;
                }
            }

            Console.WriteLine("Пользователя с таким индексом нет в базе");

            return false;
        }

        public void ShowPlayers()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                Console.WriteLine($"Порядковый номер {_players[i].Id} Имя пользователя {_players[i].UserName} Левел {_players[i].Level} Есть ли у пользователя бан {_players[i].IsBlocked} \n");
            }
        }

        public void TryAddPlayer()
        {
            string userName;
            string inputUser;

            int id;
            int level;

            bool isBlocked;

            Console.Write($"Для создания нового пользователя ведите его имя:");
            userName = Console.ReadLine();

            id = Autoincrement++;

            level = InputValidationInt("Ведите левел пользователя:");
           
            Console.Write("Заблокирован ли пользователь (true/false)");
            inputUser = Console.ReadLine();

            isBlocked = inputUser == "true";

            if (CheckForUnique(userName))
            {
                AddPlayer(new Player(id, userName, level, isBlocked));
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

            if (IsThereIndex(id, "Пользователь успешно удалён"))
            {
                DeletePlayer(id);
            }
            else
            {
                Console.WriteLine("Ошибка удаление пользователя");
            }
        }

        public void TryPlayerBlock()
        {
            int id;

            id = InputValidationInt("Ведите порядковый номер пользователя которого хотите заблокировать:");

            if (IsThereIndex(id, "Пользователь успешно заблокирован"))
            {
                Block(id);
            }
        }

        public void TryPlayerUnlock()
        {
            int id;

            id = InputValidationInt("Ведите порядковый номер пользователя которого хотите разблокировкировать:");

            if (IsThereIndex(id, "Пользователь успешно разблокирован"))
            {
                Unlock(id);
            }
        }
    }
}