using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MotifWindow : IWindow
    {
        public void Draw()
        {
            Console.WriteLine("================");
            Console.WriteLine("#              #");
            Console.WriteLine("#              #");
            Console.WriteLine("================");
        }
    }
}
