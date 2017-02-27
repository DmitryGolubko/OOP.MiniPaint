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
        //public Points BasePoint { get; private set; }

        //public Figure(Points point)
        //{
        //    //this.BasePoint = point;
        //}
        
        public abstract void Draw(Graphics g);
    }
}
