using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AbstractFigureClassLibrary;

namespace PolygonClassLibrary
{
    [Serializable]
    class Trianlge : Polygon
    {
        public override void GetParams()
        {
            base.GetParams();
            DrawPoints = new List<Point>();
            DrawPoints.Add(new Point(((StartX + EndX) / 2), StartY));          //1 dot
            DrawPoints.Add(new Point(EndX, EndY));                             //2 dot
            DrawPoints.Add(new Point(StartX, EndY));                           //3 dot
        }
    }
}
