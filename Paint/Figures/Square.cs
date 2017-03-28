﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint.Figures
{
    public class Square : Rectangle 
    {
        private int length;
        public Square()
        {
        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            A = Points[Points.Count - 1].X;
            B = Points[Points.Count - 1].Y;
            length = (Math.Abs(StartX - A) + Math.Abs(StartY - B))/2;
            return true;
        }

        public override void Draw(Graphics g)
        {
            GetParams();
            if (((StartX - A) > 0) && ((StartY - B) > 0))
            {
                g.DrawRectangle(BrushParams, StartX - (StartX - A), StartY - (StartY - B), length, length);
            }
            //if (((StartX - A) > 0) && ((StartY - B) < 0))
            //{
            //    g.DrawRectangle(BrushParams, StartX - (StartX - A), StartY, length, length);
            //}
            //if (((StartX - A) < 0) && ((StartY - B) > 0))
            //{
            //    g.DrawRectangle(BrushParams, StartX, StartY - (StartY - B), length, length);
            //}
            if (((StartX - A) < 0) && ((StartY - B) < 0))
            {
                g.DrawRectangle(BrushParams, StartX, StartY, length, length);
            }
        }
    }
}
