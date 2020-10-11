using Han.ISceneGraph;
using System;

namespace Han.SceneGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            ISceneNode root;
            root = new GroupNode("Root");
            IVisitor printGraph = new PrintVisitor();
            root.Accept(printGraph);
            ISceneNode node = new Cube("cube");
            (root as GroupNode).AddChild(node);
            node = new Cube("cube2");
            (root as GroupNode).AddChild(node);
            GroupNode snowman = new GroupNode("snowman");
            (root as GroupNode).AddChild(snowman);
            node = new Cube("Bottom");
            snowman.AddChild(node);
            node = new Cube("Middle");
            snowman.AddChild(node);
            node = new Cube("Top");
            snowman.AddChild(node);
            root.Accept(printGraph);
        }
    }
}
