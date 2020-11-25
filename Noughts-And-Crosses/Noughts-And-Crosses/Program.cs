using System;

namespace Noughts_And_Crosses
{
    class Game
    {
        static void Main(string[] args)
        {
            GameBoard GameBoard = new GameBoard();
            GameBoard.DrawGameBoard();
            GameObjects Object = new GameObjects();
            int flag = 1;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Point p;
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.NumPad7)
                    {
                        if (flag % 2 != 0) p = new Point('X', 12, 5);
                        else p = new Point('O', 12, 5);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad8)
                    {
                        if (flag % 2 != 0) p = new Point('X', 38, 5);
                        else p = new Point('O', 38, 5);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad9)
                    {
                        if (flag % 2 != 0) p = new Point('X', 67, 5);
                        else p = new Point('O', 67, 5);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad4)
                    {
                        if (flag % 2 != 0) p = new Point('X', 12, 12);
                        else p = new Point('O', 12, 12);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad5)
                    {
                        if (flag % 2 != 0) p = new Point('X', 38, 12);
                        else p = new Point('O', 38, 12);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad6)
                    {
                        if (flag % 2 != 0) p = new Point('X', 67, 12);
                        else p = new Point('O', 67, 12);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad1)
                    {
                        if (flag % 2 != 0) p = new Point('X', 12, 20);
                        else p = new Point('O', 12, 20);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad2)
                    {
                        if (flag % 2 != 0) p = new Point('X', 38, 20);
                        else p = new Point('O', 38, 20);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    else if (key.Key == ConsoleKey.NumPad3)
                    {
                        if (flag % 2 != 0) p = new Point('X', 67, 20);
                        else p = new Point('O', 67, 20);
                        Object.DrawObject(p);
                        flag++;
                        GameBoard.СountGameSquare--;
                    }
                    if (GameBoard.СountGameSquare == 0)
                    {
                        Console.SetCursorPosition(42, 12);
                        Console.WriteLine("ИГРА ЗАКОНЧЕНА!");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
