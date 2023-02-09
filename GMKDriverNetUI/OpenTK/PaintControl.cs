using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMKDriverNetUI.OpenTK
{
    public partial class  PaintControl : GLControl
    {
        public Shader shader;
        public bool _loaded;

        public PaintControl()
        {
            InitializeComponent();
        }
        private void GLControl_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.3f, 0.2f, 0.3f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
            GL.Viewport(0, 0, Width, Height);
            shader = new Shader("shader.vert", "shader.frag");
            shader.Use();
            _loaded = true;
            Invalidate();
        }

        private void GLControl_Resize(object sender, EventArgs e)
        {
            if (!_loaded)
                return;
            GL.Viewport(0, 0, Width, Height);
            Invalidate();
        }

        private void GLControl_Paint(object sender, PaintEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            shader.Use();
            SwapBuffers();
        }
    }
}
