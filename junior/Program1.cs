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
            int personX = 0, personY = 0;
            char[,] map = ReadMap("map1",ref personX,ref personY);
           

            DrawMap(map);
            Console.SetCursorPosition(personY, personX);


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
        static char[,] ReadMap(string nameMap,ref int personX,ref int personY)
        {
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