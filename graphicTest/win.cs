using System;
using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace graphicTest
{
    internal class win : GameWindow
    {
        private int vertexBufferHandle;

        public win()
            : base(GameWindowSettings.Default, NativeWindowSettings.Default) 
        {
            this.CenterWindow(new Vector2i(1280, 768));
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height);
            base.OnResize(e);
        }


        protected override void OnLoad()
        {
            GL.ClearColor(new Color4(0.3f, 0.4f, 0.5f, 1f));
            float[] vertices = new float[] 
            { 
                0.0f, 0.5f, 0f,
                0.5f, -0.5f, 0f
                -0.5f, -0.5f, 0f,   
            };

            this.vertexBufferHandle = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.vertexBufferHandle);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);


            base.OnLoad();
        }

        protected override void OnUnload()
        {
            base.OnUnload();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            
            GL.Clear(ClearBufferMask.ColorBufferBit);
            this.Context.SwapBuffers();
            base.OnRenderFrame(args);
        }
    }
}
