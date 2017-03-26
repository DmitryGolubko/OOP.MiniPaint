﻿using System;
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
        private Graphics graphics;
        private List<Figure> Figures;
        private Figure figure;
        private Pen pen;
        //private Bitmap buffer;

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
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
            //buffer = new Bitmap((int)graphics.VisibleClipBounds.Width, (int)graphics.VisibleClipBounds.Height);
        }
                              
        private void DrawAll()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graphics);
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                figure.AddPoint(new Point(e.X, e.Y));
                figure.BrushParams = new Pen(pen.Color, pen.Width);
                Figures.Add(figure);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure != null) && (e.Button == MouseButtons.Left))
            {
                figure.EndPoint(new Point(e.X, e.Y));
                graphics.Clear(Color.White);
                figure.Draw(graphics);
                DrawAll();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            { 
                DrawAll();
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics);
            }
            figure = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            graphics.Clear(Color.White);
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {   
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height; 
        }
    }
}
