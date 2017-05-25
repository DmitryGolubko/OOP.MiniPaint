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
        public int CenterX;
        public int CenterY;

        public Ellipse()
        {

        }

        public override void GetParams()
        {

            base.GetParams();
            CenterX = StartX + ((EndX - StartX) / 2);
            CenterY = StartY + ((EndY - StartY) / 2);
        }

        public override void Draw(Graphics g, Color color)
        {
            GetParams();
            g.DrawEllipse(new Pen(color, widthParams), StartX, StartY, (EndX-StartX), (EndY-StartY));
        }

        public override bool IsPointInFigure(Point point)
        {
            return (((Math.Pow((point.X - CenterX), 2) / Math.Pow(((EndX - StartX)/2),2)) + (Math.Pow((point.Y - CenterY), 2) / Math.Pow(((EndY - StartY) / 2), 2))) <= 1);
        }
    }
}
