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
            Console.CursorVisible = false;
            int personX, personY;
            int personDX = 0, personDY = 0;

            string userInputMap;
            char[,] map;

            bool isPlaying = true;

            Console.Write("Ведите название карты:");
            userInputMap = Console.ReadLine();
            Console.Clear();

            map = ReadMap(userInputMap, out personX, out personY);

            DrawMap(map);

            while (isPlaying == true)
            {
                if (Console.KeyAvailable)
                {
                    EnteredPlayerCommands(ref personDX, ref personDY, ref isPlaying);
                    MovePlayer(ref personX, ref personY, ref personDX, ref personDY, map);
                }
            }
        }
        static void MovePlayer(ref int personX, ref int personY, ref int personDX, ref int personDY, char[,] map)
        {
            if (map[personX + personDX, personY + personDY] != '|')
            {
                Console.SetCursorPosition(personY, personX);
                Console.Write(" ");

                personX += personDX;
                personY += personDY;

                Console.SetCursorPosition(personY, personX);
                Console.Write("@");
            }
        }
        static void EnteredPlayerCommands(ref int personDX, ref int personDY, ref bool isPlaying)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    personDX = -1;
                    personDY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    personDX = +1;
                    personDY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    personDX = 0;
                    personDY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    personDX = 0;
                    personDY = +1;
                    break;
                case ConsoleKey.Escape:
                    isPlaying = false;
                    break;
            }
        }
        
        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] ReadMap(string nameMap, out int personX, out int personY)
        {
            personX = 0;
            personY = 0;
            string[] newFile = System.IO.File.ReadAllLines($"Maps\\{nameMap}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {

                    if (newFile[i][j] == '%')
                    {
                        personX = i;
                        personY = j;
                        map[i, j] = '@';
                    }
                    else
                    {
                        map[i, j] = newFile[i][j];
                    }
                }
            }
            return map;
        }
    }
}