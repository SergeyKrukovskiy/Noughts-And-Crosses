using System;
using System.Collections.Generic;
using System.Text;

namespace Noughts_And_Crosses
{
    class Point
    {
        internal char symbol;
        internal int x;
        internal int y;

        internal Point()
        {
        }
        internal Point (char symbol, int x, int y)
        {
            this.symbol = symbol;
            this.x = x;
            this.y = y;
        }
        internal void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
