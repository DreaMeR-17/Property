﻿using System;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Render render = new Render();
            Player player = new Player(35, 15, '@');
            render.DrawPlayer(player);
        }
    }

    class Player
    {
        public Player(int positionX, int positionY, char symbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Symbol = symbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Symbol { get; private set; }
    }

    class Render
    {
        public void DrawPlayer(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.WriteLine(player.Symbol);
        }
    }
}
