using System;
using System.Collections.Generic;
using System.Text;

namespace Han.SceneGraph
{
    [Serializable()]
    internal class Building: DrawableNodeBase
    {
        public Building(string name):base(name)
        {

        }
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a building...");
        }
    }
}
