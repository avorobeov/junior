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
        }
    }

    class Player
    {
        private int _index;
        private string _username;
        private int _level;
        private bool _isBlocked;

        public Player(int index, string username, int lavel, bool isBlocked)
        {
            _index = index;
            _username = username;
            _level = lavel;
            _isBlocked = isBlocked;
        }
    }

    class PlayerDatabase
    {
        private Player[] _players = new Player[0];

        private const int ArrayGrowth = 1;
        public void AddPlaer(Player player)
        {
            Player[] expandArray = new Player[_players.Length + ArrayGrowth];

            for (int i = 0; i < _players.Length; i++)
            {
                _players[i] = _players[i];
            }

            expandArray[expandArray.Length - ArrayGrowth] = player;

            _players = expandArray;

        }

        
    }


}