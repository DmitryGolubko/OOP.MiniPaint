using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AbstractFigureClassLibrary;

namespace EllipseClassLibrary
{
    [Serializable]
    public class Circle : Ellipse
    {
        private int diameter;
        public Circle()
        {
        }

        public override void  GetParams()
        {
            base.GetParams();
            CenterX = StartX + ((EndX - StartX) / 2);
            CenterY = StartY + ((EndY - StartY) / 2);
            diameter = (Math.Abs(StartX - EndX) + Math.Abs(StartY - EndY)) / 2;
        }

        public override void Draw(Graphics g, Color color)
        {
            GetParams();
            if (((StartX - EndX) > 0) && ((StartY - EndX) > 0))       //works
            {
                g.DrawEllipse(new Pen(color, widthParams), StartX - (StartX - EndX), StartY - (StartY - EndY), diameter, diameter);
            }
            if (((StartX - EndX) > 0) && ((StartY - EndX) < 0))
            {
                g.DrawEllipse(new Pen(color, widthParams), StartX - (StartX - EndX), StartY, diameter, diameter);
            }
            if (((StartX - EndX) < 0) && ((StartY - EndX) > 0))
            {
                g.DrawEllipse(new Pen(color, widthParams), StartX, StartY - (StartY - EndY), diameter, diameter);
            }
            if (((StartX - EndX) < 0) && ((StartY - EndX) < 0))           //works
            {
                g.DrawEllipse(new Pen(color, widthParams), StartX, StartY, diameter, diameter);
            }
        }

        public override bool IsPointInFigure(Point point)
        {
            return ((Math.Pow((point.X - CenterX), 2) + (Math.Pow((point.Y - CenterY), 2))) <= Math.Pow((diameter / 2), 2));
        }
    }
}
