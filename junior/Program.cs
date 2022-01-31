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

            Console.Write("Ведите название карты:");
            userInputMap = Console.ReadLine();
            Console.Clear();

            map = ReadMap(userInputMap, out personX,out personY);

            bool isPlaying = true;
            DrawMap(map);

            while (isPlaying == true)
            {
                if (Console.KeyAvailable)
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
            }


            Console.ReadKey();

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
        static char[,] ReadMap(string nameMap,out int personX,out int personY)
        {
            personX = 0;
            personY = 0;
            string [] newFile = System.IO.File.ReadAllLines($"Maps\\{nameMap}.txt");
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