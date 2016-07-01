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
            //рамочка
            HorizontalLine topLine = new HorizontalLine(0, 0, 78, '#');
            topLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 24, '#');
            leftLine.Draw();

            HorizontalLine bottomLine = new HorizontalLine(0, 24, 78, '#');
            bottomLine.Draw();

            VerticalLine rightLine = new VerticalLine(78, 0, 24, '#');
            rightLine.Draw();


            //Нарисовали змейку
            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p,5,Direction.RIGHT);
            snake.Draw();

            //Управление змейки
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
            

            Console.ReadLine();
        }

    }
}
