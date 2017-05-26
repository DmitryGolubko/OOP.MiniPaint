using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigureClassLibrary
{
    public abstract class Creator
    {
        public string Name { get; set; }
        public abstract Figure CreateFigure(); 
    }
}
