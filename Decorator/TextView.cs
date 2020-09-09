using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TextView : IVisualComponent
    {
        public int Width = 16;
        public string Text = "Hello Decorator!";
        public void Draw()
        {
            Console.WriteLine(Text);
        }
    }
}
