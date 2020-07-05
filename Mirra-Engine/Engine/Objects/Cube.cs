using Mirra_Engine.Graphics2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using Mirra_Engine.Camera;

namespace Mirra_Engine.Objects
{
    class Cube : GameObject
    {
        float[] _buffer =
        {
        // | Positions          | Normals            | Texture coords
            -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 0.0f,
             0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 0.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 1.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  1.0f, 1.0f,
            -0.5f,  0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f,  0.0f,  0.0f, -1.0f,  0.0f, 0.0f,

            -0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  0.0f, 0.0f,
             0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  1.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  1.0f, 1.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  1.0f, 1.0f,
            -0.5f,  0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f,  0.0f,  0.0f,  1.0f,  0.0f, 0.0f,

            -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 0.0f,
            -0.5f,  0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 1.0f,
            -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
            -0.5f, -0.5f, -0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
            -0.5f, -0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  0.0f, 0.0f,
            -0.5f,  0.5f,  0.5f, -1.0f,  0.0f,  0.0f,  1.0f, 0.0f,

             0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 0.0f,
             0.5f,  0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 1.0f,
             0.5f, -0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  0.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  1.0f,  0.0f,  0.0f,  1.0f, 0.0f,

            -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 1.0f,
             0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 1.0f,
             0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 0.0f,
             0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  1.0f, 0.0f,
            -0.5f, -0.5f,  0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 0.0f,
            -0.5f, -0.5f, -0.5f,  0.0f, -1.0f,  0.0f,  0.0f, 1.0f,

            -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 1.0f,
             0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 1.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 0.0f,
             0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  1.0f, 0.0f,
            -0.5f,  0.5f,  0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 0.0f,
            -0.5f,  0.5f, -0.5f,  0.0f,  1.0f,  0.0f,  0.0f, 1.0f
        };

        private int _gfx; // Vertex Array Object
        private int _vbo; // Vertex Buffer Object
        private int _stride = 8; // Walk Stride for Buffer

        Dictionary<string, Texture> _textures; // List of Textures

        Shader _default;
        Vector3 _light_dir;

        public Cube(Vector3 position, Texture[] textures, Vector3 light_dir, BufferUsageHint drawMode = BufferUsageHint.StaticDraw) : base()
        {

            // Create the Inital Buffer
            _vbo = GL.GenBuffer();
            // Bind the Buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);
            // Set the Buffer Data(Vertices) to the first 3 slots from the _buffer
            GL.BufferData(BufferTarget.ArrayBuffer, _buffer.Length * sizeof(float), _buffer, drawMode);

            // Create Textures Map
            _textures = new Dictionary<string, Texture>();

            // Apply each texture pased in
            foreach (Texture tex in textures)
            {
                _textures.Add($"{tex.Name}", tex);
            }

            // Create the Actual Graphic
            _gfx = GL.GenVertexArray();
            // Bind the Graphic the the VertexArray
            GL.BindVertexArray(_gfx);

            // Apply the Data to the Vertex Buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);

            _default = new Shader("Shaders/shader.vert", "Shaders/direction_light.frag");

            ApplyShader(_default);
            Transform.SetPosition(position);
            _light_dir = light_dir;
        }

        private void ApplyShader(Shader shader)
        {
            var vertexLocation = shader.GetAttribLocation("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, _stride * sizeof(float), 0);

            var normalLocation = shader.GetAttribLocation("aNormal");
            GL.EnableVertexAttribArray(normalLocation);
            GL.VertexAttribPointer(normalLocation, 3, VertexAttribPointerType.Float, false, _stride * sizeof(float), 3 * sizeof(float));

            var texCoordinates = shader.GetAttribLocation("aTexCoords");
            GL.EnableVertexAttribArray(texCoordinates);
            GL.VertexAttribPointer(texCoordinates, 2, VertexAttribPointerType.Float, false, _stride * sizeof(float), 6 * sizeof(float));

        }

        public override void Update()
        {

            base.Update();
        }
        public override void Render(PerspectiveCamera cam)
        {
            GL.BindVertexArray(_gfx);

            int c = 0;
            // Loop through all avalable Textures 
            // Tell the Shader Use Each Texture in its respective spot
            foreach (var tex in this._textures)
            {
                if (c == 1)
                    tex.Value.Use(TextureUnit.Texture1);
                else
                    tex.Value.Use();
                
                c++;
            }

            // Apply the Default Shader
            _default.Use();

            // Apply Global View Matrix
            _default.SetMatrix4("model", Matrix4.CreateTranslation(this.Transform.GetPosition()));
            _default.SetMatrix4("view", cam.GetViewMatrix());
            _default.SetMatrix4("projection", cam.GetProjectionMatrix());

            // Update View Matrix
            _default.SetVector3("viewPosition", cam.Position);

            _default.SetInt("material.diffuse", 0);
            _default.SetInt("material.specular", 1);
            _default.SetFloat("material.shine", 32.0f);

            _default.SetVector3("light.direction", _light_dir);
            _default.SetVector3("light.ambient", new Vector3(0.2f));
            _default.SetVector3("light.diffuse", new Vector3(0.5f));
            _default.SetVector3("light.specular", new Vector3(1.0f));


            GL.DrawArrays(PrimitiveType.Triangles, 0,36);
            GL.BindVertexArray(_gfx);

            base.Render(cam);
        }
    }
}
