using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public static class ClientBridge
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("BRIDGE\n\n");

            Window window;
            window = new Window(Window.Implementors.XWindow);
            window.DrawRect(0, 0, 5, 5);
            Console.WriteLine("\n");

            window.DrawText(0, 0, "Hello Bridge!");
            Console.WriteLine("\n");


            IconWindow iconWindow = new IconWindow(Window.Implementors.XWindow);
            iconWindow.DrawBorder(0, 0, "Hello Bridge!");
            Console.WriteLine("\n");


            TransientWindow transientWindow = new TransientWindow(Window.Implementors.XWindow);
            transientWindow.DrawCloseBox(5, 0);

            Console.WriteLine('\n' + new string('_', 15) + '\n');

            window = new Window(Window.Implementors.PMWindow);
            window.DrawRect(0, 0, 5, 5);
            Console.WriteLine("\n");

            window.DrawText(0, 0, "Hello Bridge!");
            Console.WriteLine("\n");


            iconWindow = new IconWindow(Window.Implementors.PMWindow);
            iconWindow.DrawBorder(0, 0, "Hello Bridge!");
            Console.WriteLine("\n");


            transientWindow = new TransientWindow(Window.Implementors.PMWindow);
            transientWindow.DrawCloseBox(5, 0);
            Console.WriteLine("\n");
        }
    }
}
