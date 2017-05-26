using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AbstractFigureClassLibrary;

namespace RectangleClassLibrary
{
    [Serializable]
    public class Rectangle : Figure
    {
        public Rectangle()
        {
        }

        public override void Draw(Graphics g, Color color)
        { 
            GetParams();
            //if (((StartX - EndX) > 0) && ((StartY - EndY) > 0))
            //{
            //    StartX = StartX - (StartX - EndX);
            //    StartY = StartY - (StartY - EndY);
            //    EndX = StartX - EndX;
            //    EndY = StartY - EndY;
            //    g.DrawRectangle(new Pen(color, widthParams), StartX, StartY, EndX, EndY);
            //    //g.DrawRectangle(new Pen(color, widthParams), StartX - (StartX - EndX), StartY - (StartY - EndY), StartX - EndX, StartY - EndY);
            //}
            //if (((StartX - EndX) > 0) && ((StartY - EndY) < 0))
            //{
            //    StartX = StartX - (StartX - EndX);
            //    StartY = StartY - (StartY - EndY);
            //    EndX = StartX - EndX;
            //    EndY = StartY - EndY;
            //    g.DrawRectangle(new Pen(color, widthParams), StartX, StartY, EndX, EndY);
            //    //g.DrawRectangle(new Pen(color, widthParams), StartX - (StartX - EndX), StartY, StartX - EndX, EndY - StartY);
            //}
            //if (((StartX - EndX) < 0) && ((StartY - EndY) > 0))
            //{
            //    StartX = StartX - (StartX - EndX);
            //    StartY = StartY - (StartY - EndY);
            //    EndX = StartX - EndX;
            //    EndY = StartY - EndY;
            //    g.DrawRectangle(new Pen(color, widthParams), StartX, StartY, EndX, EndY);
            //    //g.DrawRectangle(new Pen(color, widthParams), StartX, StartY - (StartY - EndY), EndX - StartX, StartY - EndY);
            //}
            //if (((StartX - EndX) < 0) && ((StartY - EndY) < 0))
            //{
                g.DrawRectangle(new Pen(color, widthParams), StartX, StartY, EndX - StartX, EndY - StartY);
            //}
        }

        public override bool IsPointInFigure(Point point)
        {
            return (point.X > StartX && point.X < EndX && point.Y > StartY && point.Y < EndY);
        }
    }
}

