using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Camera: TransformableNodeBase
    {
        public Camera(string name) : base(name)
        {

        }
        public override void Apply()
        {
            Console.Out.WriteLine("Applying camera transform...");
        }
        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying camera transform...");
        }
    }
}
