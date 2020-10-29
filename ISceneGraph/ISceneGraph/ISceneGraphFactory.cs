using System;
using System.Collections.Generic;
using System.Text;

namespace Han.ISceneGraph
{
    public interface ISceneGraphFactory
    {
        IDrawableNode CreateDrawableNode(string name, string DrawableType, object drawableDate);
        IGroupNode CreateGroupNode(string name, string groupeType, object groupDate);
        IStateNode CreateStateNode(string name, string stateType, object stateData);
        ITransformNode CreateTransformNode(string name, string transformType, object transformData);

    }
}
