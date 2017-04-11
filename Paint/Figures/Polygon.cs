using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Figures
{
    [Serializable]
    class Polygon : Figure
    {
        private List<Point> DrawPoints;
        private int SecondY;
        private int ThirdX;

        public Polygon()
        {
        }

        public override void GetParams()
        {
            base.GetParams();
            DrawPoints = new List<Point>();            
            DrawPoints.Add(new Point(((StartX + EndX) / 2), StartY));          //1 точкa
            SecondY = (int)((EndX - DrawPoints[0].X) * Math.Tan(36 * Math.PI / 180));
            DrawPoints.Add(new Point(EndX, StartY + SecondY));           //2 точка
            ThirdX = (int)((EndY - SecondY) * Math.Tan(18 * Math.PI / 180));
            DrawPoints.Add(new Point(EndX - ThirdX, EndY)); //3 точка
            DrawPoints.Add(new Point(StartX + ThirdX, EndY));//4 dot
            DrawPoints.Add(new Point(StartX, StartY + SecondY));  //5 dot
        }

        public override void Draw(Graphics graphics)
        {
            GetParams();
            graphics.DrawPolygon(new Pen(colorParams, widthParams), DrawPoints.ToArray());  
        }

        public override bool IsPointInFigure(Point point)
        {
            return false;
        }
    }
}
