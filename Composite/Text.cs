using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Text : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Hello Patterns!");
        }
    }
}
