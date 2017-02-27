using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Line : Figure
    {
        private Point BeginPoint { get; set; }
        private Point EndPoint { get; set; }

        public Line(Point beginPoint, Point endPoint)
        {
            this.BeginPoint = beginPoint;
            this.EndPoint = endPoint;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black), BeginPoint.X, BeginPoint.Y, EndPoint.X, EndPoint.Y);
        }
    }
}
