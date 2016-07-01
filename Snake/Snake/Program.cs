using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.WriteLine("For start press Enter....");
            Console.ReadLine();

            int score = 0;
            int speed = 300;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Нарисовали Точки
            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreatFood(getFigureList(walls.getFigureList(),snake));
            food.Draw();


            //Управление змейки
            while (true)
            {
                if (walls.isHit(snake) || snake.isHitTail()) break;
                walls.Draw();

                if (snake.Eat(food))
                {
                    food = foodCreator.CreatFood(getFigureList(walls.getFigureList(), snake));
                    food.Draw();
                    if (speed >= 25) speed -= 25;
                    score++;
                }
                else snake.Move();

                Thread.Sleep(speed);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }

            Console.Clear();
            Console.WriteLine("Game over!!!!!!");
            Console.WriteLine("Score: " + score);
            Console.ReadLine();
        }

        static List<Figure> getFigureList(List<Figure> figureList, Figure f = null) {
            List < Figure > figList = new List<Figure>(figureList);
            if (f != null) figList.Add(f);
            return figList;
        }

    }
}
