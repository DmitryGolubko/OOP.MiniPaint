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

        public abstract bool GetParams();

        public abstract void Draw(Graphics graphics);

        public abstract bool IsPointInFigure(Point point);
    }
}
