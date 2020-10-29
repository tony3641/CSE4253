using System;
using System.Collections.Generic;
using System.Text;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Cube : DrawableNodeBase
    {
        public Cube(String name) : base(name)
        {

        }
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a cube...");
        }
    }
}
