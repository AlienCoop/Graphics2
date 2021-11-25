using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.WinForms;

namespace Graphics2
{
   
    public partial class Form1 : Form
    {
        Elements elements = new Elements();
        OpenGL gl = new OpenGL();   
        public Form1()
        {
            InitializeComponent();
        }

        private void points_Click(object sender, EventArgs e)
        {
            elements.Points(gl);
        }

        private void lines_Click(object sender, EventArgs e)
        {
            elements.Lines(gl);
        }

        private void linesSrtip_Click(object sender, EventArgs e)
        {
            elements.Linesstrip(gl);
        }

        private void LinesLoop_Click(object sender, EventArgs e)
        {
            elements.Lineloop(gl);
        }

        private void Trianglefan_Click(object sender, EventArgs e)
        {
            elements.Trianglefan(gl);
        }

        private void TriangleStrip_Click(object sender, EventArgs e)
        {
            elements.Trianglestrip(gl);
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            elements.Triangle(gl);
        }

        private void Quad_Click(object sender, EventArgs e)
        {
            elements.Quad(gl);
        }

        private void QuadStrip_Click(object sender, EventArgs e)
        {
            elements.QuadStrip(gl);
        }

        private void Polygon_Click(object sender, EventArgs e)
        {
            elements.Polygon(gl);
        }
    }
}
