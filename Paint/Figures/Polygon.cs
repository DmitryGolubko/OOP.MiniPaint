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
            Points = new List<Point>();
        }

        public override bool GetParams()
        {
            DrawPoints = new List<Point>();            
            DrawPoints.Add(new Point(((Points[0].X + Points[Points.Count - 1].X) / 2), Points[0].Y));          //1 точкa
            SecondY = (int)((Points[Points.Count - 1].X - DrawPoints[0].X) * Math.Tan(36 * Math.PI / 180));
            DrawPoints.Add(new Point(Points[Points.Count - 1].X, Points[0].Y + SecondY));           //2 точка
            ThirdX = (int)((Points[Points.Count - 1].Y - SecondY) * Math.Tan(18 * Math.PI / 180));
            DrawPoints.Add(new Point(Points[Points.Count - 1].X - ThirdX, Points[Points.Count - 1].Y)); //3 точка
            DrawPoints.Add(new Point(Points[0].X + ThirdX, Points[Points.Count - 1].Y));//4 dot
            DrawPoints.Add(new Point(Points[0].X, Points[0].Y + SecondY));  //5 dot
            return true;
        }

       

        public override void Draw(Graphics graphics)
        {
            GetParams();
            graphics.DrawPolygon(new Pen(colorParams, widthParams), DrawPoints.ToArray());  
        }
    }
}
