using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Paint.Figures
{
    public class Square : Rectangle 
    {
        public Square(Point beginPoint, int length) : base(beginPoint, length, length)
        {

        }
    }
}
