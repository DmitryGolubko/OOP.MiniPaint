using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    public class Line : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Line(Point beginPoint, int endX, int endY) : base(beginPoint)
        {
            this.X = endX;
            this.Y = endY;
        }
    }
}
