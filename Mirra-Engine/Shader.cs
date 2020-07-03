using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;

/// Creating a Shader Program.

/// Compile Each Shader
///     -- load shader glsl source code
///     -- create empy shader shell 
///     -- bind the glsl source to the empty shader shell
///     -- compile the shader

/// Merge Shaders so OpenGL can use them.
///     -- create the Handle program
///     -- attach the shaders to the program
///     -- Link them together 


namespace Mirra_Engine.Graphics2D
{
    public class Shader
    {
        public readonly int Handle;
        private readonly Dictionary<string, int> _uniformLocations;
        public Shader(string vertPath, string fragPath)
        {



            ///////////////////////////////////////////////
            // VERTEX SHADER  /////////////////////////////
            ///////////////////////////////////////////////

            // load shader source
            var shaderSrc = LoadSource(vertPath);

            // Create an empty Shader
            var vertexShader = GL.CreateShader(ShaderType.VertexShader);

            // Bind the GLSL source Code to the Shader
            GL.ShaderSource(vertexShader, shaderSrc);

            // Compile the Shader
            CompileShader(vertexShader);

            //////////////////////////////////////////////////
            // FRAGMENT SHADER  //////////////////////////////
            //////////////////////////////////////////////////

            // load shader source
            shaderSrc = LoadSource(fragPath);

            // Create empty Shader
            var fragmentShader = GL.CreateShader(ShaderType.FragmentShader);

            // Bind the GLSL source code to Shader
            GL.ShaderSource(fragmentShader, shaderSrc);
            CompileShader(fragmentShader);

            //////////////////////////////////////////////////
            // LINK SHADERS //////////////////////////////////
            //////////////////////////////////////////////////

            Handle = GL.CreateProgram();

            // attach shaders
            GL.AttachShader(Handle, vertexShader);
            GL.AttachShader(Handle, fragmentShader);

            // link shaders
            LinkProgram(Handle);

            // Detach
            GL.DetachShader(Handle, vertexShader);
            GL.DetachShader(Handle, fragmentShader);

            // private void OnDrawGizmosSelected() {

            GL.DeleteShader(fragmentShader);
            GL.DeleteShader(vertexShader);

            // CACHE shader uniforms for later use
            GL.GetProgram(Handle, GetProgramParameterName.ActiveUniforms, out var numUniforms);

            // allocate dict to hold the locations

            _uniformLocations = new Dictionary<string, int>();

            for (var i = 0; i < numUniforms; i++)
            {
                // get the name of the uniform
                var key = GL.GetActiveUniform(Handle, i, out _, out _);
                // get the location of the uniform
                var location = GL.GetUniformLocation(Handle, key);
                // add the uniform to the dictionary
                _uniformLocations.Add(key, location);
            }


        }


        private static void CompileShader(int shader)
        {
            // try to compile shader
            GL.CompileShader(shader);
            // check for compiler errors
            GL.GetShader(shader, ShaderParameter.CompileStatus, out var code);
            if (code != (int)All.True)
            {
                var infoLog = GL.GetShaderInfoLog(shader);
                throw new Exception($"Error occoured while compiling shader({shader}).\n\n{infoLog}");
            }

        }

        private static void LinkProgram(int program)
        {
            // link the program
            GL.LinkProgram(program);

            GL.GetProgram(program, GetProgramParameterName.LinkStatus, out var code);
            if (code != (int)All.True)
            {
                throw new Exception($"Error occoured while Linking Program({program})");
            }
        }

        public void Use()
        {
            GL.UseProgram(Handle);
        }

        public int GetAttribLocation(string attribName)
        {
            return GL.GetAttribLocation(Handle, attribName);
        }

        private static string LoadSource(string path)
        {
            using (var sr = new StreamReader(path, Encoding.UTF8))
            {
                return sr.ReadToEnd();
            }
        }
        ///////////////////////////////////////////////////////
        // UNIFORM SETTERS ////////////////////////////////////
        ///////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////
        // Setting a uniform is almost always the exact same.
        // ---------------------------------------------------------------- 
        //     1. Bind the program you want to set the uniform on
        //     2. Get a handle to the location of the uniform with
        //          -- GL.GetUniformLocation.
        //     3. Use the appropriate GL.Uniform* function to 
        //          set the uniform.
        ///////////////////////////////////////////////////////////////////

        ///<summary>
        /// Set a uniform int on this Shader
        ///<summary>
        ///<param name="name">the name of the uniform</param>
        ///<param name="data">the data to set </param>
        public void SetInt(string name, int data)
        {
            GL.UseProgram(Handle);
            GL.Uniform1(_uniformLocations[name], data);
        }

        ///<summary>
        /// Set a uniform float on this Shader
        ///<summary>
        ///<param name="name">the name of the uniform</param>
        ///<param name="data">the data to set </param>
        public void SetFloat(string name, float data)
        {
            GL.UseProgram(Handle);
            GL.Uniform1(_uniformLocations[name], data);
        }

        ///<summary>
        /// Set abstract Uniform Matrix4 on this Shader
        ///<summary>
        ///<param name="name">the name of the uniform</param>
        ///<param name="data">the data to be set</param>
        ///<remarks>
        ///     <para>
        ///         The Matrix is Transposed before being sent to the Shader.
        ///     </para>
        ///<remarks>
        public void SetMatrix4(string name, Matrix4 data)
        {
            GL.UseProgram(Handle);
            GL.UniformMatrix4(_uniformLocations[name], true, ref data);
        }

        ///<summary>
        /// Set a uniform Vector3 on this Shader
        ///<summary>
        ///<param name="name">the name of the uniform</param>
        ///<param name="data">the data to set </param>
        public void SetVector3(string name, Vector3 data)
        {
            GL.UseProgram(Handle);
            GL.Uniform3(_uniformLocations[name], data);
        }
    }
}
