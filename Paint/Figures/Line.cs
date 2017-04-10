using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    [Serializable]
    public class Line : Figure
    {
        private int EndX;
        private int EndY;

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

        public override void Draw(Graphics g)
        {   
            GetParams();
            g.DrawLine(new Pen(colorParams, widthParams), StartX, StartY, EndX, EndY);
        }

        public override bool IsPointInFigure(Point point)
        {
            return false;
        }
    }
}
