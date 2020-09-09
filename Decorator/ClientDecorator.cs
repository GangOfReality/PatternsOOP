using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public static class ClientDecorator
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("DECORATOR\n\n");

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
