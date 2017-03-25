using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Figures
{
    class Polygon : Figure
    {
        public Point Point2;
        public Point Point3;
        public Point Point4;
        private List<Point> DrawPoints;

        public Polygon()
        {
            Points = new List<Point>();
        }

        public override bool GetParams()
        {
            DrawPoints = new List<Point>();
            DrawPoints.Add(new Point(Points[0].X + 50, Points[0].Y));                    //1 точка
            DrawPoints.Add(new Point(Points[0].X + 100, Points[0].Y + 50));          //2 точка
            DrawPoints.Add(new Point(Points[0].X, Points[0].Y + 50));          //3 точка
            DrawPoints.Add(new Point(Points[Points.Count- 1].X - 50, Points[Points.Count - 1].Y));          //4 точка
            DrawPoints.Add(new Point(Points[Points.Count - 1].X, Points[Points.Count - 1].Y));          //5 точка
            return true;
        }

       

        public override void Draw(Graphics graphics)
        {
            GetParams();
            graphics.DrawPolygon(BrushParams, DrawPoints.ToArray());  
        }
    }
}
