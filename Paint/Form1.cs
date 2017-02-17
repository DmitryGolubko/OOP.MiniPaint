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
            var ellipse = new Ellipse(new Point(150, 70), 150, 100);
            var graphics = this.CreateGraphics();
            graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black), ellipse.BasePoint.X, ellipse.BasePoint.Y, ellipse.A, ellipse.B);
            
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            var circle = new Circle(new Point(200, 200), 100);
            var graphics = this.CreateGraphics();
            graphics.DrawEllipse(new System.Drawing.Pen(System.Drawing.Color.Black), circle.BasePoint.X, circle.BasePoint.Y, circle.A, circle.B);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = new Rectangle(new Point(300, 300), 200, 100);
            var graphics = this.CreateGraphics();
            graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Black), rectangle.BasePoint.X, rectangle.BasePoint.Y, rectangle.Width, rectangle.Height);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            var square = new Square(new Point(350, 150), 100);
            var graphics = this.CreateGraphics();
            graphics.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.Black), square.BasePoint.X, square.BasePoint.Y, square.Height, square.Width);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            var line = new Line(new Point(200, 400), 370, 450);
            var graphics = this.CreateGraphics();
            graphics.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), line.BasePoint.X, line.BasePoint.Y, line.X, line.Y);
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle(new Point(100, 100), 150, 150, 170, 170);
            //graphics.DrawPolygon(new System.Drawing.Pen(System.Drawing.Color.Black), )
        }
    }
}
