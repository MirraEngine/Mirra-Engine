using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using Mirra_Engine.Graphics2D;
using Mirra_Engine.Camera;
using OpenTK.Input;

namespace Mirra_Engine
{
    public partial class Engine : MetroForm
    {
        // Create a Square

        private readonly float[] _vertices =
        {
        //  |Position          |Texture Coordinates
             0.5f,  0.5f, 0.0f, 1.0f, 0.0f,     // top-right 
             0.5f, -0.5f, 0.0f, 1.0f, 1.0f,     // bottom-right 
            -0.5f, -0.5f, 0.0f, 0.0f, 1.0f,     // bottom-left 
            -0.5f,  0.5f, 0.0f, 0.0f, 0.0f,     // top-left 
        };
        uint[] indices = {
            0,1,3,
            1,2,3
        };

        // Create pointers to VBO and VAO

        // Vertex Buffer Object
        private int stride = 5;
        private int _vertexBufferObject;

        // Vertex Array Object
        private int _vertexArrayObject;

        private int _elementBufferObject;

        private Shader _shader;
        private Texture _texture;
        private Texture _texture2;


        // Time Passed since start of program
        private double _time;
        private PerspectiveCamera _camera;
        private bool _firstMove = true;
        private Vector2 _lastPos;
        private bool _can_update = false;

        const float cameraSpeed = 1f;
        const float sensitivity = 0.2f;

        private bool _loaded = false;

        public Engine()
        {
            InitializeComponent();
        }


        private void TogglePanel(Panel p)
        {
            
            if(p.Visible == true)
            {
                p.Visible = false;
            }
            else
            {
                p.Visible = true;
            }

        }

        #region SCENE_VIEW 
        
        ///////////////////////////////////////////////////////////////////
        ////  ON LOAD      ////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////
        
        private void SceneView_Init(object sender, EventArgs e)
        {
            GL.ClearColor(.1f, .1f, .1f, 1f);
            GL.Enable(EnableCap.DepthTest);

            ///////////////////////////////////////////////////////////////////////////
            // VBO INIT         /////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            // CREATE 
            _vertexBufferObject = GL.GenBuffer();
            // BIND
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            // ADD
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);

            ///////////////////////////////////////////////////////////////////////////
            // EBO INIT         /////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            // CREATE
            _elementBufferObject = GL.GenBuffer();
            // BIND
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _elementBufferObject);
            // ADD
            GL.BufferData(BufferTarget.ElementArrayBuffer, indices.Length * sizeof(uint), indices, BufferUsageHint.StaticDraw);


            _shader = new Shader("Shaders/vs.glsl", "Shaders/fs.glsl");
            _shader.Use();

            _texture = new Texture("Assets/textures/brick.jpg");
            _texture.Use();

            _texture2 = new Texture("Assets/textures/OpenGL_test.png");
            _texture2.Use(TextureUnit.Texture1);


            _shader.SetInt("texture0", 0);
            _shader.SetInt("texture1", 1);

            ///////////////////////////////////////////////////////////////////////////
            // VAO INIT         ///////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////
            // CREATE
            _vertexArrayObject = GL.GenVertexArray();
            // BIND
            GL.BindVertexArray(_vertexArrayObject);

            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, _elementBufferObject);

            // ADD
            var vertexLocation = _shader.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, stride * sizeof(float), 0);

            var texCoorLocation = _shader.GetAttribLocation("aTexCoord");
            GL.EnableVertexAttribArray(texCoorLocation);
            GL.VertexAttribPointer(texCoorLocation, 3, VertexAttribPointerType.Float, false, stride * sizeof(float), 3 * sizeof(float));


            // _view = Matrix4.CreateTranslation(0.0f,-1f,-3f);
            _camera = new PerspectiveCamera(new Vector3(0, 1f, 3f), Width / (float)Height);
            // CursorVisible = false;
            _loaded = true;

            scene_view.Invalidate();

        }

        private void SceneView_Render(object sender, PaintEventArgs e)
        {

            if (!_loaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.BindVertexArray(_vertexArrayObject);


            _texture.Use();
            _texture2.Use(TextureUnit.Texture1);
            _shader.Use();

            var model = Matrix4.Identity;
            model *= Matrix4.CreateRotationX(MathHelper.DegreesToRadians(-90f));
            
            _shader.SetMatrix4("model", model);
            _shader.SetMatrix4("view", _camera.GetViewMatrix());
            _shader.SetMatrix4("projection", _camera.GetProjectionMatrix());


            // GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
            GL.DrawElements(PrimitiveType.Triangles, indices.Length, DrawElementsType.UnsignedInt, 0);


            // The Render Method uses the Double Buffer Strategy
            // To Calculate what needs to be rendering before actually 
            // rendering so we nee do tell it to "Swap" to its other Buffer
            // so that it can repeat the cycle
            scene_view.SwapBuffers();
        }

        private void SceneView_OnResize(object sender, EventArgs e)
        {
            if (!_loaded)
                return;
            GL.Viewport(0, 0, scene_view.Width, scene_view.Height);
            _camera.AspectRatio = scene_view.Width / (float)scene_view.Height;
            scene_view.Invalidate();
        }

        private void SceneView_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (!_can_update)
            {
                return;
            }

            var code = e.KeyCode;

            // MOVE FORWARD
            if(code == Keys.W)
                _camera.Position += _camera.Front * cameraSpeed * 0.05f;
            // MOVE BACKWARD
            if (code == Keys.S)
                _camera.Position -= _camera.Front * cameraSpeed * 0.05f;
            // MOVE LEFT
            if (code == Keys.A)
                _camera.Position -= _camera.Right * cameraSpeed * 0.05f;
            // MOVE RIGHT
            if (code == Keys.D)
                _camera.Position += _camera.Right * cameraSpeed * 0.05f;
            // MOVE DOWN
            if (code == Keys.E)
                _camera.Position += _camera.Up* cameraSpeed * 0.05f;
            // MOVE UP
            if (code == Keys.Q)
                _camera.Position -= _camera.Up * cameraSpeed * 0.05f;
            
            scene_view.Invalidate();
        }

        private void SceneView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            KeyboardState keyboard_state = Keyboard.GetState();
            MouseState mouse_state = Mouse.GetState();

            if (keyboard_state.IsKeyDown(Key.AltLeft))
            {


                //var mouse_state = Mouse.GetState();

                if (_firstMove)
                {
                    _lastPos = new Vector2(mouse_state.X, mouse_state.Y);
                    _firstMove = false;

                }
                else
                {

                    // calculate the offset of the mouse Position
                    var deltaX = mouse_state.X - _lastPos.X;
                    var deltaY = mouse_state.Y - _lastPos.Y;

                    // apply the camrea pitch and yaw
                    _camera.Yaw += deltaX * sensitivity;
                    _camera.Pitch -= deltaY * sensitivity;

                    _lastPos = new Vector2(mouse_state.X, mouse_state.Y);

                }
            }
            else
            {
                _lastPos = new Vector2(mouse_state.X, mouse_state.Y);
            }
        }

        private void Control_Heirarchy_Btn_Click(object sender, EventArgs e)
        {
            TogglePanel(Heirarchy_Panel);
        }

        private void Control_Inspector_Btn_Click(object sender, EventArgs e)
        {
            TogglePanel(Inspector_Panel);
        }

        private void Control_Console_Btn_Click(object sender, EventArgs e)
        {
            TogglePanel(Console_Panel);
        }
        #endregion

        private void SceneView_MouseEnter(object sender, EventArgs e)
        {
            _can_update = true;
        }

        private void SceneView_MouseLeave(object sender, EventArgs e)
        {
            _can_update = false;

        }

        private void SceneView_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        }
    }
}
