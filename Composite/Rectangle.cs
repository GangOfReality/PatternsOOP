using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// This class is leaf.
    /// Can not have the children.
    /// </summary>
    class Rectangle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("|         |");
            Console.WriteLine("|         |");
            Console.WriteLine("-----------");
        }
    }
}
