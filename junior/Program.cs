﻿using System;
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
            int knightPositionX;
            int knightPositionY;

            Knight knight = new Knight();
            Renderer renderer = new Renderer();

            knight.SetPosition(10, 10);

            knightPositionX = knight.PositionX;
            knightPositionY = knight.PositionY;

            renderer.DrawPlayer(knightPositionX, knightPositionY);

            Console.ReadLine();
        }
    }
    class Renderer
    {
        public void DrawPlayer(int positionX, int positionY, char character = '$')
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(character);
        }
    }
    class Knight
    {
        private int _health;
        private int _armor;
        private int _damage;

        private int _positionX;
        private int _positionY;

        public int PositionX
        {
            get
            {
                return _positionX;
            }
       
            private set
            {
                _positionX = value;
            }
        }
      
        public int PositionY
        {
            get
            {
                return _positionY;
            }
        
            private set
            {
                _positionY = value;
            }
        }
      
        public Knight(int health, int armor, int damage)
        {
            _health = health;
            _armor = armor;
            _damage = damage;
        }
      
        public Knight()
        {
            _health = 150;
            _armor = 30;
            _damage = 25;
        }
      
        public void ShowInfo()
        {
            Console.WriteLine($"Количество здоровья {_health} \n" +
                              $"Количество брони {_armor}\n" +
                              $"Количество урона {_damage}");
        }
      
        public void SetPosition(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}