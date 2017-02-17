using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    public class Square : Rectangle 
    {
        public Square(Point point, int length) : base(point, length, length)
        {

        }
    }
}
