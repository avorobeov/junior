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
            PlayerDatabase database = new PlayerDatabase();

            database.AddPlaer(new Player(1, "dic", 2, false));
            database.AddPlaer(new Player(2, "dic", 2, false));
            database.AddPlaer(new Player(3, "dic", 2, false));

            database.DeletePlaer(2);
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
    }

    class PlayerDatabase
    {
        private Player[] _players = new Player[0];

        private const int ArrayGrowth = 1;
        public bool AddPlaer(Player player)
        {
            Player[] expandArray = new Player[_players.Length + ArrayGrowth];

            for (int i = 0; i < _players.Length; i++)
            {
                expandArray[i] = _players[i];
            }

            expandArray[expandArray.Length - ArrayGrowth] = player;

            _players = expandArray;

            return true;

        }

        public bool DeletePlaer(int index)
        {
            Player[] expandArray = new Player[_players.Length - ArrayGrowth];

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
                            expandArray[i - ArrayGrowth] = _players[i];
                        }
                    }
                }
            }

            _players = expandArray;

            return true;
        }


    }


}