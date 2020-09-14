using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class IconWindow : Window
    {
        public IconWindow(Window.Implementors implementors) : base(implementors)
        {
        }
        public void DrawBorder(int startX, int startY, string text)
        {
            DrawRect(startX, startY, startX + text.Length + 1, startY + 2);
            DrawText(startX + 1, startY - 2, text);
        }
    }
}
