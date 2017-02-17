namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EllipseButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(12, 12);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(120, 47);
            this.EllipseButton.TabIndex = 0;
            this.EllipseButton.Text = "Нарисовать эллипс";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(12, 65);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(120, 47);
            this.CircleButton.TabIndex = 1;
            this.CircleButton.Text = "Нарисовать круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(12, 118);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(120, 47);
            this.RectangleButton.TabIndex = 2;
            this.RectangleButton.Text = "Нарисовать прямоугольник";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // SquareButton
            // 
            this.SquareButton.Location = new System.Drawing.Point(12, 171);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(120, 47);
            this.SquareButton.TabIndex = 3;
            this.SquareButton.Text = "Нарисовать квадрат";
            this.SquareButton.UseVisualStyleBackColor = true;
            this.SquareButton.Click += new System.EventHandler(this.SquareButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(12, 224);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(120, 47);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "Нарисовать линию";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(12, 277);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(120, 47);
            this.TriangleButton.TabIndex = 5;
            this.TriangleButton.Text = "Нарисовать треугольник";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 514);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.EllipseButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button TriangleButton;
    }
}

