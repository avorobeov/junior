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

            database.AddPlaer(new Player(1, "den", 2, false));
            database.AddPlaer(new Player(2, "valoda", 2, false));

            string inputUser;

            bool isExit = false;

            while (isExit == false)
            {
                ShowMenu();

                inputUser = Console.ReadLine();

                switch (inputUser)
                {
                    case "1":
                        AddPlaer(database);
                        break;

                    case "2":
                        DelitePlaer(database);
                        break;

                    case "3":
                        PlayerBan(database);
                        break;

                    case "4":
                        database.ShowPlayers();
                        break;

                    case "5":
                        isExit = true;
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Для создания пользователя нажмите 1 \n" +
                              "Для удаления пользователя нажмите 2 \n" +
                              "Для блокировки/разблокировки пользователя нажмите 3 \n" +
                              "Для вывода всех пользователей нажмите  4 \n" +
                              "Для выхода из программы веди 5");
        }

        static void AddPlaer(Database database)
        {

            string userName;
            string inputUser;

            int index;
            int level;

            bool isBlocked;

            Console.Write($"Для создания нового пользователя ведите его имя:");
            userName = Console.ReadLine();

            Console.Write("Ведите индекс пользователя:");
            inputUser = Console.ReadLine();

            Int32.TryParse(inputUser, out index);

            Console.Write("Ведите левел пользователя:");
            inputUser = Console.ReadLine();

            Int32.TryParse(inputUser, out level);

            Console.Write("Заблокирован ли пользователь (true/false)");
            inputUser = Console.ReadLine();

            isBlocked = inputUser == "true";

            if (database.CheckForUnique(userName, index))
            {
                database.AddPlaer(new Player(index, userName, level, isBlocked));
            }
            else
            {
                Console.WriteLine("Данные не прошли  проверку на уникальность попробуйте ещё раз");
            }
        }

        static void DelitePlaer(Database database)
        {
            string inputUser;

            int index;

            Console.WriteLine("Ведите порядковый номер пользователя которого хотите удалить:");
            inputUser = Console.ReadLine();

            Int32.TryParse(inputUser, out index);

            if (database.DeletePlaer(index))
            {
                Console.WriteLine("Пользователь удалён");
            }
            else
            {
                Console.WriteLine("Ошибка удаление пользователя");
            }
        }

        static void PlayerBan(Database database)
        {
            string inputUser;

            int index;

            Console.WriteLine("Если вы хотите забанить пользователя, нажмите 1 \n" +
                              "Если вы хотите разбанить пользователя, нажмите 2");
            inputUser = Console.ReadLine();

            if (inputUser == "1")
            {
                Console.WriteLine("Ведите порядковый номер пользователя которого хотите забанить:");
                inputUser = Console.ReadLine();

                Int32.TryParse(inputUser, out index);

                database.BlockAndUnblock(index, true);

                Console.WriteLine("Пользователь заблокирован");
            }
            else if (inputUser == "2")
            {
                Console.WriteLine("Ведите номер пользователя которого хотите разбанить:");
                inputUser = Console.ReadLine();

                Int32.TryParse(inputUser, out index);

                database.BlockAndUnblock(index, false);

                Console.WriteLine("Пользователь разблокирован");
            }
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

        public void Ban(bool solution)
        {
            if (solution == true)
            {
                IsBlocked = true;
            }
            else
            {
                IsBlocked = false;
            }
        }
    }

    class Database
    {
        private Player[] _players = new Player[0];

        public bool AddPlaer(Player player)
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

        public bool DeletePlaer(int index)
        {
            Player[] expandArray = new Player[_players.Length - 1];

            if (_players.Length >= index)
            {
                for (int i = 0; i < _players.Length; i++)
                {
                    if (_players[i].Index != index)
                    {
                        if (expandArray.Length > i)
                        {
                            expandArray[i] = _players[i];
                        }
                        else
                        {
                            expandArray[i - 1] = _players[i];
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            _players = expandArray;

            return true;
        }

        public bool BlockAndUnblock(int index, bool solution)
        {
            if (_players.Length >= index)
            {
                _players[index - 1].Ban(solution);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckForUnique(string userName, int index)
        {
            for (int i = 0; i < _players.Length; i++)
            {
                if (_players[i].UserName != userName && _players[i].Index != index)
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
    
        public void ShowPlayers()
        {
            for (int i = 0; i < _players.Length; i++)
            {
                Console.WriteLine($"Порядковый номер {_players[i].Index} Имя пользователя {_players[i].UserName} Левел {_players[i].Level} Есть ли у пользователя бан {_players[i].IsBlocked} \n");
            }
        }
    }
}