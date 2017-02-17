using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Figures;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            var ellipse = new Ellipse(new Point(200, 200), 150, 100);
            var graphics = this.CreateGraphics();
            graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black), ellipse.BasePoint.X, ellipse.BasePoint.Y, ellipse.A, ellipse.B);
            var circle = new Circle(new Point(300, 300), 50);
            graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black), circle.BasePoint.X, circle.BasePoint.Y, circle.A, circle.B);
        }
    }
}
