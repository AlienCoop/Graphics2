using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graphics2
{
    public class Elements
    {

        public void Triangle(OpenGL gl)
        {
            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1f, -1f);
            gl.Vertex(0f, 1f);
            gl.Vertex(1f, -1f);
            gl.End();
        }

        public void Quad(OpenGL gl)
        {
            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(0.2f, 0.8);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(0.2f, 0.4f);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0.8f, 0.4f);
            gl.Vertex(0.8f, 0.8f);
            gl.End();
        }

        public void QuadStrip(OpenGL gl)
        {

            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_QUAD_STRIP);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(0f, -0.5f);
            gl.Vertex(0f, 0.5f);
            gl.Vertex(0.5f, -0.5f);
            gl.Vertex(0.5f, 0.5f);
            gl.Vertex(1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f);


            gl.End();
        }

        public void Trianglestrip(OpenGL gl)
        {
            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 0.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0.5f);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.5f, 1.0f);
            gl.End();
        }

        public void Trianglefan(OpenGL gl)
        {
            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);


            gl.Begin(OpenGL.GL_TRIANGLE_FAN);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 0.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, 0.5f);
            gl.Vertex(-0.4f, 0.6f);
            gl.End();

        }

        public void Polygon(OpenGL gl)
        {
            gl.PolygonMode(SharpGL.Enumerations.FaceMode.FrontAndBack, SharpGL.Enumerations.PolygonMode.Lines);

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 0.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-0.5f, 1.1f);
            gl.End();
        }

        public void Lineloop(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 0.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-0.5f, 1.1f);
            gl.End();
        }
        public void Lines(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_LINES);
            gl.LineWidth(50);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 1.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-0.5f, 1.1f);
            gl.Vertex(-1.0f, 2.3f);
            gl.End();
        }
        public void Linesstrip(OpenGL gl)
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.LineWidth(50);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 1.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-0.5f, 1.1f);
            gl.Vertex(-1.0f, 2.3f);
            gl.End();
        }
        public void Points(OpenGL gl)
        {     
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
      
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -5.0f);

            gl.Begin(OpenGL.GL_POINTS);
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(0, 0);
            gl.Color(0.5f, 1.0f, 0.0f);
            gl.Vertex(0, 1.5f);
            gl.Color(1.0f, 1.0f, 0.5f);
            gl.Vertex(0.5f, 0);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(-0.7f, -0.7f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-0.5f, 1.1f);
            gl.Vertex(-1.0f, 2.3f);
            gl.End();
        }
    }
}
