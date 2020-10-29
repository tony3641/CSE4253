using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class GroupNode : IGroupNode
    {
        public GroupNode(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            private set;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            foreach (ISceneNode child in children)
                child.Accept(visitor);
            visitor.PostVisit(this);
        }

        public void AddChild(ISceneNode child)
        {
            children.Add(child);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<ISceneNode> GetEnumerator()
        {
            return children.GetEnumerator();
        }

        private IList<ISceneNode> children = new List<ISceneNode>(8);
    }
}
