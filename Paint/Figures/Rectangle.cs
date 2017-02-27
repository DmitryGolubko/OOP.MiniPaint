using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Rectangle : Figure
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private Point BeginPoint { get; set; }

        public Rectangle(Point beginpoint, int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.BeginPoint = beginpoint;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black), BeginPoint.X, BeginPoint.Y, Width, Height);
        }
    }
}
