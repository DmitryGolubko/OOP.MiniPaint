using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Circle : Ellipse
    {
        public Circle()
        {
        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            A = Points[Points.Count - 1].X;
            return true;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            GetParams();
            g.DrawEllipse(pen, StartX, StartY, (A - StartX), (A-StartX));
        }
    }
}
