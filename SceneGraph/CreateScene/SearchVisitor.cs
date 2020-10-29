using System;
using System.Collections.Generic;
using System.Text;
using Han.ISceneGraph;

namespace CreateScene
{
    class SearchVisitor : IVisitor
    {
        private SearchVisitor(string targetName)
        {
            this.targetString = targetName;
            this.notFound = true;
        }

        private readonly string targetString;
        private bool notFound;
        private ISceneNode result;
        static public ISceneNode Find(string targetName, ISceneNode root)
        {
            SearchVisitor visitor = new SearchVisitor(targetName);
            visitor.PreBranchVisit(root);
            return visitor.getResult();
        }

        public ISceneNode getResult()
        {
            return result;
        }

        private void CompareToTarget(ISceneNode node)
        {
            if (notFound && targetString == node.Name)
            {
                notFound = false;
                this.result = node;
            }
        }

        private void PreBranchVisit(ISceneNode node)
        {
            if (node is IGroupNode){
                PreVisit((IGroupNode)node);
            }
            else if (node is IDrawableNode){
                PreVisit((IDrawableNode)node);
            }
            else if (node is IStateNode){
                PreVisit((IStateNode)node);
            }
            else if (node is ITransformNode){
                PreVisit((ITransformNode)node);
            }
        }

        public void PreVisit(IDrawableNode node)
        {
            CompareToTarget(node);
        }

        public void PreVisit(ITransformNode node)
        {
            CompareToTarget(node);
        }

        public void PreVisit(IStateNode node)
        {
            CompareToTarget(node);
        }

        public void PreVisit(IGroupNode node)
        {
            CompareToTarget(node);

            foreach (ISceneNode child in node)
            {
                PreBranchVisit(child);
            }
        }

        public void PostVisit(IDrawableNode drawable)
        {
            throw new NotImplementedException();
        }

        public void PostVisit(ITransformNode transform)
        {
            throw new NotImplementedException();
        }

        public void PostVisit(IStateNode state)
        {
            throw new NotImplementedException();
        }

        public void PostVisit(IGroupNode group)
        {
            throw new NotImplementedException();
        }
    }
}
