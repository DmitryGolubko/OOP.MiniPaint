using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    [Serializable]
    public class Ellipse : Figure
    {
        public int EndX;
        public int EndY;
        public int CenterX;
        public int CenterY;

        public Ellipse()
        {

        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            EndX = Points[Points.Count - 1].X;
            EndY = Points[Points.Count - 1].Y;
            CenterX = StartX + ((EndX - StartX) / 2);
            CenterY = StartY + ((EndY - StartY) / 2);
            return true;
        }

        public override void Draw(Graphics g)
        {
            GetParams();
            g.DrawEllipse(new Pen(colorParams, widthParams), StartX, StartY, (EndX-StartX), (EndY-StartY));
        }

        public override bool IsPointInFigure(Point point)
        {
            return (((Math.Pow((point.X - CenterX), 2) / Math.Pow(((EndX - StartX)/2),2)) + (Math.Pow((point.Y - CenterY), 2) / Math.Pow(((EndY - StartY) / 2), 2))) <= 1);
        }
    }
}
