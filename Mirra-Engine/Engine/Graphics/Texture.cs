using System.Drawing;
using System.Drawing.Imaging;
using OpenTK.Graphics.OpenGL4;
using PixelFormat = OpenTK.Graphics.OpenGL4.PixelFormat;


namespace Mirra_Engine.Graphics2D
{
    class Texture
    {
        public readonly int Handle;
        public string Name;
        
        // Creates a Texture from the specified _path_
        public Texture(string path, string name)
        {
            // Generate the handle
            Handle = GL.GenTexture();
            Name = name;

            // Bind the handle
            Use();

            // Load Texture
            using (var img = new Bitmap(path))
            {
                // Get Pixel Data
                var data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, img.Width, img.Height, 0, PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            }
            
            // Set Min and Mag Filters
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            // Set Wrap Mode
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            // Generate MipMaps
            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

        }

        public void Use(TextureUnit u = TextureUnit.Texture0)
        {
            GL.ActiveTexture(u);
            GL.BindTexture(TextureTarget.Texture2D, Handle);
        }
    }
}