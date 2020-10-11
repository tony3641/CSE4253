using System;
using System.Collections.Generic;
using System.Text;

namespace Han.ISceneGraph
{
    public interface IStateNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
