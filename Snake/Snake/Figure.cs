using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<Point> pList;
        
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool isHit(Figure figure)
        {
            foreach (var p in pList) {
                if (figure.isHit(p)) return true;
            }
            return false;
        }

        public bool isHit(Point point) {
            foreach (var p in pList)
            {
                if (p.isHit(point)) return true;
            }
            return false;
        }
    }
}
