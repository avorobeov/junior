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
                        database.AttemptToAddPlayer();
                        break;

                    case "2":
                        database.AttemptToDelitePlayer();
                        break;

                    case "3":
                        database.AttemptToPlayerBlock();
                        break;

                    case "4":
                        database.AttemptToPlayerUnlock();
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

        private int _index;
        private int _level;

        private bool _isBlocked;

        public int Index
        {
            get
            {
                return _index;
            }
            private set
            {
                _index = value;
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

        public Player(int index, string username, int lavel, bool isBlocked)
        {
            _index = index;
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

        private void DeletePlayer(int index)
        {
            Player[] expandArray = new Player[_players.Length - 1];

            bool isDelete = false;

            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Index != index)
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

        private void Block(int index)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if(_players[i].Index == index)
                {
                    _players[i].Block();
                }
            }
        }

        private void Unlock(int index)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Index == index)
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

        private bool IsThereIndex(int index, string text)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].Index == index)
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
                Console.WriteLine($"Порядковый номер {_players[i].Index} Имя пользователя {_players[i].UserName} Левел {_players[i].Level} Есть ли у пользователя бан {_players[i].IsBlocked} \n");
            }
        }

        public void AttemptToAddPlayer()
        {
            string userName;
            string inputUser;

            int index;
            int level;

            bool isBlocked;

            Console.Write($"Для создания нового пользователя ведите его имя:");
            userName = Console.ReadLine();

            index = Autoincrement++;

            level = InputValidationInt("Ведите левел пользователя:");
           
            Console.Write("Заблокирован ли пользователь (true/false)");
            inputUser = Console.ReadLine();

            isBlocked = inputUser == "true";

            if (CheckForUnique(userName))
            {
                AddPlayer(new Player(index, userName, level, isBlocked));
            }
            else
            {
                Console.WriteLine("Данные не прошли  проверку на уникальность попробуйте ещё раз");
            }
        }

        public void AttemptToDelitePlayer()
        {
            int index;

            index = InputValidationInt("Ведите порядковый номер пользователя которого хотите удалить:");

            if (IsThereIndex(index, "Пользователь успешно удалён"))
            {
                DeletePlayer(index);
            }
            else
            {
                Console.WriteLine("Ошибка удаление пользователя");
            }
        }

        public void AttemptToPlayerBlock()
        {
            int index;

            index = InputValidationInt("Ведите порядковый номер пользователя которого хотите заблокировать:");

            if (IsThereIndex(index, "Пользователь успешно заблокирован"))
            {
                Block(index);
            }
        }

        public void AttemptToPlayerUnlock()
        {
            int index;

            index = InputValidationInt("Ведите порядковый номер пользователя которого хотите разблокировкировать:");

            if (IsThereIndex(index, "Пользователь успешно разблокирован"))
            {
                Unlock(index);
            }
        }
    }
}