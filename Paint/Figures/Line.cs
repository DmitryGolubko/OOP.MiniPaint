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
        public int EndX;
        public int EndY;

        public Line()
        {
          
        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            EndX = Points[Points.Count - 1].X;
            EndY = Points[Points.Count - 1].Y;
            return true;
        }

        public override void Draw(Graphics g, Pen pen)
        {   
            GetParams();
            g.DrawLine(pen, StartX, StartY, EndX, EndY);
        }
    }
}
