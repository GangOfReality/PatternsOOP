using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public static class ClientDecorator
    {
        public static void ExecuteScript()
        {
            IVisualComponent visualComponent = new TextView();

            visualComponent.Draw();
            Console.WriteLine("\n\n\n");

            visualComponent = new BorderDecorator(visualComponent, 16);

            visualComponent.Draw();
            Console.WriteLine("\n\n\n");

            visualComponent = new ScrollDecorator(visualComponent, 10);

            visualComponent.Draw();
            Console.WriteLine("\n\n\n");
        }
    }
}
