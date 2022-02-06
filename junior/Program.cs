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
            DataBase database = new DataBase();

            database.AddPlaer(new Player(1, "dic", 2, false));
            database.AddPlaer(new Player(2, "dic", 2, false));

            database.DeletePlaer(2);

            database.BlockAndUnblock(1, true);
        }
    }

    class Player
    {
        private int _index;
        private string _userName;
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

    class DataBase
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

            _players = expandArray;

            return true;
        }

        public bool BlockAndUnblock(int index, bool solution)
        {
            if (_players.Length >= index)
            {
                _players[index].Ban(solution);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}