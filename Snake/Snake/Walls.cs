using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        public List<Figure> wallList;

        public Walls(int width, int height) {
            wallList = new List<Figure>();

            //рамочка
            HorizontalLine topLine = new HorizontalLine(0, 0,width-2, '#');
            VerticalLine leftLine = new VerticalLine(0, 0, height-1, '#');
            HorizontalLine bottomLine = new HorizontalLine(0, height-2, width-2, '#');
            VerticalLine rightLine = new VerticalLine(width-2, 0, height-1, '#');

            wallList.Add(topLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
            wallList.Add(bottomLine);
        }
        
        internal bool isHit(Figure figure) {
            foreach (var wall in wallList) {
                if (wall.isHit(figure)) return true;
            }
            return false;
        }
        
        public void Draw() {
            foreach (var wall in wallList) {
                wall.Draw();
            }
        }

        public List<Figure> getFigureList() {
            return wallList;
        }
    }
}
