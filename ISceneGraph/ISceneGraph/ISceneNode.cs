﻿namespace Han.ISceneGraph
{
    public interface ISceneNode
    {
        void Accept(IVisitor visitor);
        string Name { get; }
    }
}
