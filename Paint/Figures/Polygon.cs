using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    class Polygon : Figure
    {
        public List<Point> Points { get; private set; }

        public Polygon()
        {
            Points = new List<Point>();
        }
        
        public void AddPoint(Point point)
        {
            Points.Add(point);
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(new Pen(Color.Black), Points.ToArray());  
        }
    }
}
