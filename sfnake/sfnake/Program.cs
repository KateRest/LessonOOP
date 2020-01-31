using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sfnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            //Отрисовка полей
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '#');
            UpLine.Drow();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '#');
            DownLine.Drow();
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '#');
            LeftLine.Drow();
            VerticalLine ReigtLine = new VerticalLine(0, 24, 78, '#');
            ReigtLine.Drow();

            //Отрисовка точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
