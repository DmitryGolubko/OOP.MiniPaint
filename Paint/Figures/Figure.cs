using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{

    public abstract class Figure
    {
        public List<Point> Points;
        public int StartX;
        public int StartY; 

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

        public abstract void Draw(Graphics g);
    }
}
