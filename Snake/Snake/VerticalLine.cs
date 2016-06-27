using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
   
        public VerticalLine(int yTop, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }

        }

    }
}
