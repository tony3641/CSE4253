﻿using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    internal abstract class DrawableNodeBase : IDrawableNode
    {
        protected DrawableNodeBase(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            protected set;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public abstract void Draw();
    }
}
