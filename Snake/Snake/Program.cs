using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3, '*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine topLine = new HorizontalLine(0, 0, 78, '#');
            topLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 0, 24, '#');
            leftLine.Draw();

            HorizontalLine bottomLine = new HorizontalLine(0, 24, 78, '#');
            bottomLine.Draw();

            VerticalLine rightLine = new VerticalLine(78, 0, 24, '#');
            rightLine.Draw();


            Console.ReadLine();
        }

    }
}
