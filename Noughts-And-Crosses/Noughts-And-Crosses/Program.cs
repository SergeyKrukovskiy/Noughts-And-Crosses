using System;

namespace Noughts_And_Crosses
{
    class Game
    {
        static void Main(string[] args)
        {
            GameBoard game = new GameBoard();
            game.DrawGameBoard();

            GameObjects Object = new GameObjects();
            Point p = new Point('X', 12, 5);
            Point p2 = new Point('O', 38, 5);
            Object.DrawObject(p);
            Object.DrawObject(p2);

            Console.ReadLine();
        }
    }
}
