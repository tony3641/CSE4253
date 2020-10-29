using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class DrawMode : IStateNode
    {
        public DrawMode(string name)
        {
            this.Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public string Name
        {
            get;
            protected set;
        }

        public void Apply()
        {
            Console.WriteLine("Applying drawmode...");
        }

        public void UnApply()
        {
            Console.WriteLine("Unapplying drawmode...");
        }
    }
}
