using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PMWindow : IWindow
    {
        public void Draw()
        {
            Console.WriteLine("________________");
            Console.WriteLine("|              |");
            Console.WriteLine("|              |");
            Console.WriteLine("________________");
        }
    }
}
