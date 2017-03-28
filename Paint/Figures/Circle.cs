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
        private int diameter;
        public Circle()
        {
        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            A = Points[Points.Count - 1].X;
            B = Points[Points.Count - 1].Y;
            diameter = (Math.Abs(StartX - A) + Math.Abs(StartY - B)) / 2;
            return true;
        }

        public override void Draw(Graphics g)
        {
            GetParams();
            if (((StartX - A) > 0) && ((StartY - A) > 0))       //works
            {
                g.DrawEllipse(BrushParams, StartX - (StartX - A), StartY - (StartY - B), diameter, diameter);
            }
            if (((StartX - A) > 0) && ((StartY - A) < 0))
            {
                g.DrawEllipse(BrushParams, StartX - (StartX - A), StartY, diameter, diameter);
            }
            if (((StartX - A) < 0) && ((StartY - A) > 0))
            {
                g.DrawEllipse(BrushParams, StartX, StartY - (StartY - B), diameter, diameter);
            }
            if (((StartX - A) < 0) && ((StartY - A) < 0))           //работает
            {
                g.DrawEllipse(BrushParams, StartX, StartY, diameter, diameter);
            }
        }
    }
}
