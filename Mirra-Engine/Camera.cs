using System;
using OpenTK;


namespace Mirra_Engine.Camera
{
    /// Camera
    /// <summary>
    ///    
    /// <summary>
    public class PerspectiveCamera
    {
        private Vector3 _front = -Vector3.UnitZ;  // -(0, 0, -1) -> (0, 0, 1) 
        private Vector3 _up = Vector3.UnitY;  //(0, 1, 0)
        private Vector3 _right = Vector3.UnitX; //(1, 0, 0)

        /// <summary>
        ///  rotation around x-axis
        /// </summary>
        private float _pitch;

        /// <summary>
        ///  rotation around x-axis
        /// </summary>
        private float _yaw = -MathHelper.PiOver2;

        /// <summary>
        ///  the field of view(radians)
        /// </summary>
        private float _fov = MathHelper.PiOver2;

        /// <summary>
        ///     Creates a Camera in the OpenGL Context.
        /// </summary>
        /// <param name="position">Position to Instantiate this Camera</param>
        /// <param name="aspect_ratio">Aspect Ratio to give the camera</param>
        public PerspectiveCamera(Vector3 position, float aspect_ratio)
        {
            Position = position;
            AspectRatio = aspect_ratio;
        }

        /// <summary>
        /// position of this Camera (x, y, z)
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// aspect ratio of this Camera (radians)
        /// </summary>
        public float AspectRatio { private get; set; }

        /// <summary>
        /// Forward facing Vector (0, 0, 1)
        /// </summary>
        public Vector3 Front => _front;

        /// <summary>
        /// Up facing Vector (0, 1, 0)
        /// </summary>
        public Vector3 Up => _up;

        /// <summary>
        /// Right facing Vector (1, 0, 0)
        /// </summary>
        public Vector3 Right => _right;

        /// <summary>
        /// Rotation around X Axis (_pitch, 0, 0)
        /// </summary>
        public float Pitch
        {
            get => MathHelper.RadiansToDegrees(_pitch);
            set
            {
                var angle = MathHelper.Clamp(value, -89f, 89f);
                _pitch = MathHelper.DegreesToRadians(angle);
                UpdateVectors();
            }
        }

        /// <summary>
        /// Rotation around Y Axis (0, 1, 0)
        /// </summary>
        public float Yaw
        {
            get => MathHelper.RadiansToDegrees(_yaw);
            set
            {
                _yaw = MathHelper.DegreesToRadians(value);
                UpdateVectors();
            }
        }

        /// <summary>
        /// Fov (Field of View)
        /// </summary>
        public float Fov
        {
            get => MathHelper.RadiansToDegrees(_fov);
            set
            {
                var angle = MathHelper.Clamp(value, 1f, 180f);
                _fov = MathHelper.DegreesToRadians(angle);
            }
        }

        public Matrix4 GetViewMatrix()
        {
            return Matrix4.LookAt(Position, Position + _front, _up);
        }

        public Matrix4 GetProjectionMatrix()
        {
            return Matrix4.CreatePerspectiveFieldOfView(_fov, AspectRatio, 0.01f, 100f);
        }

        public void UpdateVectors()
        {
            _front.X = (float)Math.Cos(_pitch) * (float)Math.Cos(_yaw);
            _front.Y = (float)Math.Sin(_pitch);
            _front.Z = (float)Math.Cos(_pitch) * (float)Math.Sin(_yaw);

            _front = Vector3.Normalize(_front);
            
            _right = Vector3.Normalize(Vector3.Cross(_front, Vector3.UnitY));
            _up = Vector3.Normalize(Vector3.Cross(_right, _front));

        }
    }
}