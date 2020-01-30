using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1, '#');
            p1.Draw();

            Point p2 = new Point(4, 5, '*');
            p2.Draw();

            HorizontalLine Line = new HorizontalLine(3, 8, 8, '+');
            Line.Drow();

            Console.ReadLine();
        }
    }
}
