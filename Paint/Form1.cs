using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Figures;
using System.Windows.Input;
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        List<Figure> Figures;
        private Figure figure;
        GraphicsState state;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            Figures = new List<Figure>();
            pen = new Pen(Color.Black, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            pictureBoxColor.BackColor = Color.Black;
            trackBarPenWidth.Value = 1;
            pen.Width = trackBarPenWidth.Value;
            labelPenWidth.Text = "Толщина линий: " + trackBarPenWidth.Value.ToString();
        }

        

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            var polygon = new Polygon();
            polygon.AddPoint(new Point(500, 300));
            polygon.AddPoint(new Point(500, 400));
            polygon.AddPoint(new Point(450, 150));
            polygon.AddPoint(new Point(600, 200));
            polygon.Draw(graphics, pen);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null)
            { 
                figure.AddPoint(new Point(e.X, e.Y));
                Figures.Add(figure);
                //state = graphics.Save();
            }       
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                //state = graphics.Save();
                //graphics.Clear(Color.White);
                //graphics.Restore(state);
                DrawAll();
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics, pen);
                //state = graphics.Save();
                //graphics.Restore(transState);
            }
            figure = null;            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure != null) && (e.Button == MouseButtons.Left))
            {
                figure.EndPoint(new Point(e.X, e.Y));
                graphics.Clear(Color.White);
                
                figure.Draw(graphics, pen);
                //graphics.Restore(transState);
                DrawAll();
            }

        }

        private void DrawAll()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graphics, pen);
            }
        }

        private void btnFigure_MouseDown(object sender, MouseEventArgs e)
        {
            figure = new CreatorList().GetFigure(Int32.Parse((sender as Button).Tag.ToString()));

        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            pictureBoxColor.BackColor = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBarPenWidth.Value;
            labelPenWidth.Text = "Толщина линий: " + trackBarPenWidth.Value.ToString();
        }
    }
}
