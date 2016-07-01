using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth, mapHeight;
        char sym;

        Random rand = new Random();

        public FoodCreator(int _mapWidth, int _mapHeight, char _sym) {
            this.mapWidth = _mapWidth;
            this.mapHeight = _mapHeight;
            this.sym = _sym;
        }

        public Point CreatFood() {
            int x = rand.Next(2, mapWidth - 2);
            int y = rand.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
