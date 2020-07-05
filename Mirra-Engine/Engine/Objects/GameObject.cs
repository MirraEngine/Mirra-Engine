using Mirra_Engine.Camera;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mirra_Engine.Objects
{

    struct Transform
    {
        public Vector3 Position;
        public Vector3 Scale;

        public Transform(Vector3 position, Vector3 scale)
        {
            Position = position;
            Scale = scale;
        }
        public Vector3 GetPosition() => Position;
        public Vector3 GetScale() => Scale;

        public void SetPosition(Vector3 position) => Position = position;
        public void SetScale(Vector3 scale) =>  Scale = scale;   
    }

    class GameObject
    {
        public Transform Transform = new Transform(Vector3.Zero, Vector3.One);

        public GameObject()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void Render(PerspectiveCamera cam)
        {

        }
    }
}
