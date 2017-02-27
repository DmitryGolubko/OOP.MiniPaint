using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Ellipse : Figure
    {
        private int A { get; set; }
        private int B { get; set; }
        private Point Center { get; set; }

        public Ellipse(Point center, int a, int b)
        {
            this.A = a;
            this.B = b;
            this.Center = center;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), Center.X - A , Center.Y - B, A * 2, B * 2);
        }
    }
}
