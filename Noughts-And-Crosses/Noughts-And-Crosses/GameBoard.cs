using System;
using System.Collections.Generic;
using System.Text;

namespace Noughts_And_Crosses
{
    class GameBoard
    {
        public GameBoard ()
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
        }
        public void DrawGameBoard ()
        {
            for (int i = 24; i > 1; i--)
            {
                Point PointVertical = new Point('|', 24, i);
                PointVertical.Draw();
                Point PointVertical2 = new Point('|', 52, i);
                PointVertical2.Draw();
            }
            for (int i = 2; i <= 78; i++)
            {
                Point PointHorizontal = new Point('-', i, 8);
                PointHorizontal.Draw();
                Point PointHorizontal2 = new Point('-', i, 16);
                PointHorizontal2.Draw();
            }
        }
    }
}
