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
        public int A { get; set; }
        public int B { get; set; }
        

        public Ellipse()
        {

        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            A = Points[Points.Count - 1].X;
            B = Points[Points.Count - 1].Y;
            return true;
        }

        public override void Draw(Graphics g)
        {
            GetParams();
            g.DrawEllipse(new Pen(Color.Black), StartX, StartY, (A-StartX), (B-StartY));
        }
    }
}
