using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Window
    {
        private readonly IWindowImp windowImp;
        public enum Implementors { XWindow, PMWindow }
        public Window(Implementors implementors)
        {
            switch (implementors)
            {
                case Implementors.XWindow:
                    windowImp = new XWindowImp();
                    break;
                case Implementors.PMWindow:
                    windowImp = new PMWindowImp();
                    break;
            }
        }

        public void DrawText(int startX, int startY, string text)
        {
            startX += Console.CursorLeft;
            startY += Console.CursorTop;
            windowImp.DevDrawText(startX, startY, text);
        }
        public void DrawRect(int startX, int startY, int endX, int endY)
        {
            startX += Console.CursorLeft;
            startY += Console.CursorTop;
            endX += Console.CursorLeft;
            endY += Console.CursorTop;
            windowImp.DevDrawLine(startX, startY, endX - startX);
            windowImp.DevDrawLine(startX, startY, endY - startY, true);
            windowImp.DevDrawLine(endX, startY, endY - startY, true);
            windowImp.DevDrawLine(startX, endY, endX - startX + 1);
        }

    }
}
