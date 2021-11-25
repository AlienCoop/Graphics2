namespace Graphics2
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
            this.components = new System.ComponentModel.Container();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.points = new System.Windows.Forms.Button();
            this.LineStrip = new System.Windows.Forms.Button();
            this.lines = new System.Windows.Forms.Button();
            this.LinesLoop = new System.Windows.Forms.Button();
            this.Trianglefan = new System.Windows.Forms.Button();
            this.TriangleStrip = new System.Windows.Forms.Button();
            this.QuadStrip = new System.Windows.Forms.Button();
            this.Quad = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(0, 0);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(575, 316);
            this.openGLControl1.TabIndex = 1;
            // 
            // points
            // 
            this.points.Location = new System.Drawing.Point(599, 12);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(184, 23);
            this.points.TabIndex = 2;
            this.points.Text = "Точки";
            this.points.UseVisualStyleBackColor = true;
            this.points.Click += new System.EventHandler(this.points_Click);
            // 
            // LineStrip
            // 
            this.LineStrip.Location = new System.Drawing.Point(599, 70);
            this.LineStrip.Name = "LineStrip";
            this.LineStrip.Size = new System.Drawing.Size(184, 23);
            this.LineStrip.TabIndex = 11;
            this.LineStrip.Text = "Незамкнутая ломанная";
            this.LineStrip.UseVisualStyleBackColor = true;
            this.LineStrip.Click += new System.EventHandler(this.linesSrtip_Click);
            // 
            // lines
            // 
            this.lines.Location = new System.Drawing.Point(599, 41);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(184, 23);
            this.lines.TabIndex = 10;
            this.lines.Text = "Линии";
            this.lines.UseVisualStyleBackColor = true;
            this.lines.Click += new System.EventHandler(this.lines_Click);
            // 
            // LinesLoop
            // 
            this.LinesLoop.Location = new System.Drawing.Point(599, 100);
            this.LinesLoop.Name = "LinesLoop";
            this.LinesLoop.Size = new System.Drawing.Size(184, 23);
            this.LinesLoop.TabIndex = 12;
            this.LinesLoop.Text = "Замкнутая ломанная";
            this.LinesLoop.UseVisualStyleBackColor = true;
            this.LinesLoop.Click += new System.EventHandler(this.LinesLoop_Click);
            // 
            // Trianglefan
            // 
            this.Trianglefan.Location = new System.Drawing.Point(599, 158);
            this.Trianglefan.Name = "Trianglefan";
            this.Trianglefan.Size = new System.Drawing.Size(184, 23);
            this.Trianglefan.TabIndex = 14;
            this.Trianglefan.Text = "Треугольник ( с одной вершиной)";
            this.Trianglefan.UseVisualStyleBackColor = true;
            this.Trianglefan.Click += new System.EventHandler(this.Trianglefan_Click);
            // 
            // TriangleStrip
            // 
            this.TriangleStrip.Location = new System.Drawing.Point(599, 129);
            this.TriangleStrip.Name = "TriangleStrip";
            this.TriangleStrip.Size = new System.Drawing.Size(184, 23);
            this.TriangleStrip.TabIndex = 13;
            this.TriangleStrip.Text = "Треугольник (с одной стороной)";
            this.TriangleStrip.UseVisualStyleBackColor = true;
            this.TriangleStrip.Click += new System.EventHandler(this.TriangleStrip_Click);
            // 
            // QuadStrip
            // 
            this.QuadStrip.Location = new System.Drawing.Point(599, 242);
            this.QuadStrip.Name = "QuadStrip";
            this.QuadStrip.Size = new System.Drawing.Size(184, 23);
            this.QuadStrip.TabIndex = 17;
            this.QuadStrip.Text = "Квадрат (с одной стороной)";
            this.QuadStrip.UseVisualStyleBackColor = true;
            this.QuadStrip.Click += new System.EventHandler(this.QuadStrip_Click);
            // 
            // Quad
            // 
            this.Quad.Location = new System.Drawing.Point(599, 216);
            this.Quad.Name = "Quad";
            this.Quad.Size = new System.Drawing.Size(184, 20);
            this.Quad.TabIndex = 16;
            this.Quad.Text = "Квадрат";
            this.Quad.UseVisualStyleBackColor = true;
            this.Quad.Click += new System.EventHandler(this.Quad_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(599, 187);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(184, 23);
            this.Triangle.TabIndex = 15;
            this.Triangle.Text = "Треугольник";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(599, 271);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(184, 23);
            this.Polygon.TabIndex = 18;
            this.Polygon.Text = "Полигон";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 316);
            this.Controls.Add(this.Polygon);
            this.Controls.Add(this.QuadStrip);
            this.Controls.Add(this.Quad);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Trianglefan);
            this.Controls.Add(this.TriangleStrip);
            this.Controls.Add(this.LinesLoop);
            this.Controls.Add(this.LineStrip);
            this.Controls.Add(this.lines);
            this.Controls.Add(this.points);
            this.Controls.Add(this.openGLControl1);
            this.Name = "Form1";
            this.Text = "Graphics 1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button points;
        private System.Windows.Forms.Button LineStrip;
        private System.Windows.Forms.Button lines;
        private System.Windows.Forms.Button LinesLoop;
        private System.Windows.Forms.Button Trianglefan;
        private System.Windows.Forms.Button TriangleStrip;
        private System.Windows.Forms.Button QuadStrip;
        private System.Windows.Forms.Button Quad;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Polygon;
    }
}

