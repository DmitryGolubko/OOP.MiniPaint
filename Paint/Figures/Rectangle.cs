using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Rectangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rectangle()
        {
        }

        public override void Draw(Graphics g)
        { 
            GetParams();
            if (((StartX - A) > 0) && ((StartY - B) > 0))
            {
                g.DrawRectangle(BrushParams, StartX - (StartX - A), StartY - (StartY - B), StartX - A, StartY - B);
            }
            if (((StartX - A) > 0) && ((StartY - B) < 0))
            {
                g.DrawRectangle(BrushParams, StartX - (StartX - A), StartY, StartX - A, B - StartY);
            }
            if (((StartX - A) < 0) && ((StartY - B) > 0))
            {
                g.DrawRectangle(BrushParams, StartX, StartY - (StartY - B), A - StartX, StartY - B);
            }
            if (((StartX - A) < 0) && ((StartY - B) < 0))
            {
                g.DrawRectangle(BrushParams, StartX, StartY, A - StartX, B - StartY);
            }
        }

        public override bool GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            A = Points[Points.Count - 1].X;
            B = Points[Points.Count - 1].Y;
            return true;
        }
    }
}

