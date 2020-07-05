using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using OpenTK.Graphics;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using Mirra_Engine.Graphics2D;
using Mirra_Engine.Camera;
using OpenTK.Input;
using Mirra_Engine.Objects;

namespace Mirra_Engine
{
    public partial class Engine : MetroForm
    {
        // Create a Square

        private readonly float[] _quad_vertices =
        {
        //  |Position          |Texture Coordinates
             0.5f,  0.5f, 0.0f, 1.0f, 0.0f,     // top-right 
             0.5f, -0.5f, 0.0f, 1.0f, 1.0f,     // bottom-right 
            -0.5f, -0.5f, 0.0f, 0.0f, 1.0f,     // bottom-left 
            -0.5f,  0.5f, 0.0f, 0.0f, 0.0f,     // top-left 
        };
        private readonly uint[] _quad_indices = {
            0,1,3,
            1,2,3,
        };


        private readonly Vector3 _lightPosition = new Vector3(0.0f, 1.0f, 0.0f);

        private PerspectiveCamera _camera;
        private bool _firstMove = true;
        private Vector2 _lastPos;
        private bool _can_update = false;

        const float cameraSpeed = 1f;
        const float sensitivity = 0.2f;

        private bool _loaded = false;

        // SHAPES 
  

        Cube cube;
        Cube cube2;

        Vector3 sun_direction;

        public Engine()
        {
            InitializeComponent();
        }


        private void TogglePanel(Panel p)
        {

            if (p.Visible == true)
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
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1.0f);

            GL.Enable(EnableCap.DepthTest);

            // Initilize Game Object

            // Initilize Textures
            Texture[] cube_textures = {
                new Texture("Assets/textures/wooden_box.png", "diffuse"),
                new Texture("Assets/textures/wooden_box_spec.png", "specular")
            };
            sun_direction = new Vector3(-0.2f, -1.0f, -0.3f);
            cube = new Cube(new Vector3(0.0f,1.0f,0.0f), cube_textures, sun_direction);
            cube2 = new Cube(new Vector3(1.0f,0.0f,0.0f), cube_textures, sun_direction);

            _camera = new PerspectiveCamera(new Vector3(0, 1f, 3f), Width / (float)Height);


            _loaded = true;

            scene_view.Invalidate();

        }

        private void SceneView_Render(object sender, PaintEventArgs e)
        {

            if (!_loaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            cube.Render(_camera);
            cube2.Render(_camera);


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


            KeyboardState keyboard_state = Keyboard.GetState();
            MouseState mouse_state = Mouse.GetState();

            // MOVE FORWARD
            if (keyboard_state.IsKeyDown(Key.W))
                _camera.Position += _camera.Front * cameraSpeed * 0.05f;
            // MOVE BACKWARD
            if (keyboard_state.IsKeyDown(Key.S))
                _camera.Position -= _camera.Front * cameraSpeed * 0.05f;
            // MOVE LEFT
            if (keyboard_state.IsKeyDown(Key.A))
                _camera.Position -= _camera.Right * cameraSpeed * 0.05f;
            // MOVE RIGHT
            if (keyboard_state.IsKeyDown(Key.D))
                _camera.Position += _camera.Right * cameraSpeed * 0.05f;
            // MOVE DOWN
            if (keyboard_state.IsKeyDown(Key.E))
                _camera.Position += _camera.Up * cameraSpeed * 0.05f;
            // MOVE UP
            if (keyboard_state.IsKeyDown(Key.Q))
                _camera.Position -= _camera.Up * cameraSpeed * 0.05f;

            if (keyboard_state.IsKeyDown(Key.AltLeft))
            {
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

            scene_view.Invalidate();
        }

        private void SceneView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {

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

        private void SceneView_MouseScroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
