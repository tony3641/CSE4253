using System;
using System.Collections.Generic;
using System.Text;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Sphere: DrawableNodeBase
    {
        public Sphere(string name) : base(name)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing a sphere...");
        }
    }
}
