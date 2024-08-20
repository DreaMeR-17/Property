using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Symbol { get; private set; }


        public Player(int positionX, int positionY, char symbol)
        { 
            PositionX = positionX;
            PositionY = positionY;
            Symbol = symbol;
        }
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
