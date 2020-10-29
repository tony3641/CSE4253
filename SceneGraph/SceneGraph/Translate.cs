using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Translate: TransformableNodeBase
    {
        public Translate(string name) : base(name)
        {

        }
        public override void Apply()
        {
            Console.Out.WriteLine("Applying Translate transform...");
        }
        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying Translate transform...");
        }
    }
}
