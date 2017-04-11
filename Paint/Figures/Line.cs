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
        public Line()
        {
          
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
