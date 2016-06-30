using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int xPos, int yPos, int length, char sym)
        {
            pList = new List<Point>();

            for (int x = yPos; x <= yPos + length; x++)
            {
                Point p = new Point(xPos, x, sym);
                pList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
