using System;
using System.Collections.Generic;
using System.Text;

namespace Han.ISceneGraph
{
    public interface IGroupNode : ISceneNode
    {
        void AddChild(ISceneNode child);
    }
}
