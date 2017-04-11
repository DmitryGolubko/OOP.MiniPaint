using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Figures
{
    [Serializable]
    public abstract class Figure : ISelectable
    {
        public List<Point> Points;
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public Color colorParams { get; set; }
        public float widthParams { get; set; }

        public Figure()
        {
            Points = new List<Point>(0);
        }

        public void AddPoint(Point p)
        {
            Points.Add(p);
        }

        public void EndPoint(Point p)
        {
            AddPoint(p);
            Points[Points.Count - 1] = p;
        }

        public virtual void GetParams()
        {
            StartX = Points[0].X;
            StartY = Points[0].Y;
            EndX = Points[Points.Count - 1].X;
            EndY = Points[Points.Count - 1].Y;
        }

        public abstract void Draw(Graphics graphics);

        public abstract bool IsPointInFigure(Point point);
    }
}
