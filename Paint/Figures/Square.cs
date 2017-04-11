﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint.Figures
{
    [Serializable]
    public class Square : Rectangle 
    {
        private int length;
        public Square()
        {
        }

        public override void GetParams()
        {
            base.GetParams();
            length = (Math.Abs(StartX - EndX) + Math.Abs(StartY - EndY))/2;
        }

        public override void Draw(Graphics g)
        {
            GetParams();
            if (((StartX - EndX) > 0) && ((StartY - EndY) > 0))
            {
                g.DrawRectangle(new Pen(colorParams, widthParams), StartX - (StartX - EndX), StartY - (StartY - EndY), length, length);
            }
            if (((StartX - EndX) > 0) && ((StartY - EndY) < 0))
            {
                g.DrawRectangle(new Pen(colorParams, widthParams), StartX - (StartX - EndX), StartY, length, length);
            }
            if (((StartX - EndX) < 0) && ((StartY - EndY) > 0))
            {
                g.DrawRectangle(new Pen(colorParams, widthParams), StartX, StartY - (StartY - EndY), length, length);
            }
            if (((StartX - EndX) < 0) && ((StartY - EndY) < 0))
            {
                g.DrawRectangle(new Pen(colorParams, widthParams), StartX, StartY, length, length);
            }
        }

        public override bool IsPointInFigure(Point point)
        {
            return (point.X > StartX && point.X < StartX + length && point.Y > StartY && point.Y < StartY + length);
        }
    }
}
