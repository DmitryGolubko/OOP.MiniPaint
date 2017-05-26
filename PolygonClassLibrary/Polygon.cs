using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace PolygonClassLibrary
{
    [Serializable]
    class Polygon : Figure
    {
        public List<Point> DrawPoints;
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

        public override void Draw(Graphics graphics, Color color)
        {
            GetParams();
            graphics.DrawPolygon(new Pen(color, widthParams), DrawPoints.ToArray());  
        }

        public override bool IsPointInFigure(Point point)
        {
            int Intersections = 0;
            int Prev = (int)DrawPoints.LongCount() - 1;
            bool PrevUnder = DrawPoints[Prev].Y < point.Y;

            for (int i = 0; i < DrawPoints.LongCount(); i++)
            {
                bool CurUnder = DrawPoints[i].Y < point.Y;

                Point A = new Point(DrawPoints[Prev].X - point.X, DrawPoints[Prev].Y - point.Y);
                Point B = new Point(DrawPoints[i].X - point.X, DrawPoints[i].Y - point.Y);

                float T = (A.X * (B.Y - A.Y) - A.Y * (B.X - A.X));
                if (CurUnder && !PrevUnder)
                {
                    if (T > 0)
                        Intersections++;
                }
                if (!CurUnder && PrevUnder)
                {
                    if (T < 0)
                        Intersections++;
                }

                Prev = i;
                PrevUnder = CurUnder;
            }

            return Intersections % 2 != 0;
        }
    }
}
