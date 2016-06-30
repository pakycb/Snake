using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xPos, int yPos, int length, char sym)
        {
            pList = new List<Point>();

            for (int x = xPos; x <= xPos + length; x++)
            {
                Point p = new Point(x, yPos, sym);
                pList.Add(p);
            }

        }
    }
}
