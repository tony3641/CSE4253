using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Scale: TransformableNodeBase
    {
        public Scale(string name) : base(name)
        {

        }
        public override void Apply()
        {
            Console.Out.WriteLine("Applying Scale transform...");
        }
        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying Scale transform...");
        }
    }
}
