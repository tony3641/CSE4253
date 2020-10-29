using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Perspective: TransformableNodeBase
    {
        public Perspective(string name) : base(name)
        {

        }
        public override void Apply()
        {
            Console.Out.WriteLine("Applying Perspective transform...");
        }
        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying Perspective transform...");
        }
    }
}
