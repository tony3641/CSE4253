using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph

namespace Han.SceneGraph
{
    [Serializable()]
    internal abstract class TransformableNodeBase : ITransformNode
    {
        protected TransformableNodeBase(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            protected set;
        }
        public abstract void Apply();
        public abstract void UnApply();

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

    }
}
