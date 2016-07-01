using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction) {
            direction = _direction;

            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head = pList.Last();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else return false;
        }

        public bool isHitTail() {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 3; i++) {
                if (head.isHit(pList[i])) return true;
            }
            return false;
        }
        /*
        public bool isWallHit(List<Figure> walls)
        {
            Point head = pList.Last();
            foreach (var wall in walls) {
                foreach (Point poi in wall.pList)
                {
                    if (head.isHit(poi)) return true;
                }
            }
            return false;
        }
        */
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
            {
                if (direction != Direction.RIGHT) direction = Direction.LEFT;
            }
            if (key == ConsoleKey.RightArrow || key == ConsoleKey.D)
            {
                if (direction != Direction.LEFT) direction = Direction.RIGHT;
            }
            if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
            {
                if (direction != Direction.DOWN) direction = Direction.UP;
            }
            if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
            {
                if(direction != Direction.UP) direction = Direction.DOWN;
            }
        }
    }
}
