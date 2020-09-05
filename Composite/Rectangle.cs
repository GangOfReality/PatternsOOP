using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
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
