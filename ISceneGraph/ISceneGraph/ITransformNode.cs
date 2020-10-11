using System;
using System.Collections.Generic;
using System.Text;

namespace Han.ISceneGraph
{
    public interface ITransformNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
