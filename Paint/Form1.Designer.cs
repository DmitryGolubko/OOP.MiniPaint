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
            this.LineButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.trackBarPenWidth = new System.Windows.Forms.TrackBar();
            this.labelPenWidth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadLibrary = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(6, 21);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(0, 0);
            this.EllipseButton.TabIndex = 0;
            this.EllipseButton.Tag = "0";
            this.EllipseButton.Text = "Эллипс";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFigure_MouseDown);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(6, 26);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(207, 48);
            this.LineButton.TabIndex = 4;
            this.LineButton.Tag = "0";
            this.LineButton.Text = "Линия";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFigure_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EllipseButton);
            this.groupBox1.Controls.Add(this.LineButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор фигуры";
            // 
            // buttonChangeColor
            // 
            this.buttonChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeColor.Location = new System.Drawing.Point(18, 294);
            this.buttonChangeColor.Name = "buttonChangeColor";
            this.buttonChangeColor.Size = new System.Drawing.Size(207, 42);
            this.buttonChangeColor.TabIndex = 7;
            this.buttonChangeColor.Text = "Изменить цвет";
            this.buttonChangeColor.UseVisualStyleBackColor = true;
            this.buttonChangeColor.Click += new System.EventHandler(this.buttonChangeColor_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(231, 294);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(207, 42);
            this.pictureBoxColor.TabIndex = 8;
            this.pictureBoxColor.TabStop = false;
            // 
            // trackBarPenWidth
            // 
            this.trackBarPenWidth.LargeChange = 2;
            this.trackBarPenWidth.Location = new System.Drawing.Point(18, 371);
            this.trackBarPenWidth.Minimum = 1;
            this.trackBarPenWidth.Name = "trackBarPenWidth";
            this.trackBarPenWidth.Size = new System.Drawing.Size(420, 56);
            this.trackBarPenWidth.TabIndex = 9;
            this.trackBarPenWidth.Value = 6;
            this.trackBarPenWidth.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelPenWidth
            // 
            this.labelPenWidth.AutoSize = true;
            this.labelPenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPenWidth.Location = new System.Drawing.Point(14, 348);
            this.labelPenWidth.Name = "labelPenWidth";
            this.labelPenWidth.Size = new System.Drawing.Size(138, 20);
            this.labelPenWidth.TabIndex = 10;
            this.labelPenWidth.Text = "Толщина линий";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(455, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 490);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(18, 412);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(207, 42);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить поле";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSerialize.Location = new System.Drawing.Point(18, 460);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(207, 42);
            this.buttonSerialize.TabIndex = 14;
            this.buttonSerialize.Text = "Сериализовать";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeserialize.Location = new System.Drawing.Point(231, 460);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(207, 42);
            this.buttonDeserialize.TabIndex = 15;
            this.buttonDeserialize.Text = "Десериализовать";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonLoadLibrary
            // 
            this.buttonLoadLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadLibrary.Location = new System.Drawing.Point(231, 412);
            this.buttonLoadLibrary.Name = "buttonLoadLibrary";
            this.buttonLoadLibrary.Size = new System.Drawing.Size(207, 42);
            this.buttonLoadLibrary.TabIndex = 16;
            this.buttonLoadLibrary.Text = "Загрузить библиотеку";
            this.buttonLoadLibrary.UseVisualStyleBackColor = true;
            this.buttonLoadLibrary.Click += new System.EventHandler(this.buttonLoadLibrary_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1229, 514);
            this.Controls.Add(this.buttonLoadLibrary);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPenWidth);
            this.Controls.Add(this.trackBarPenWidth);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonChangeColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.TrackBar trackBarPenWidth;
        private System.Windows.Forms.Label labelPenWidth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLoadLibrary;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

