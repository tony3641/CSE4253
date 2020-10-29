using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Rotate: TransformableNodeBase
    {
        public Rotate(string name) : base(name)
        {

        }
        public override void Apply()
        {
            Console.Out.WriteLine("Applying Rotate transform...");
        }
        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying Rotate transform...");
        }
    }
}
