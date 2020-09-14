using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class TransientWindow : Window
    {
        public TransientWindow(Window.Implementors implementors) : base(implementors)
        {
        }
        public void DrawCloseBox(int startX, int startY)
        {
            DrawRect(startX + 1, startY, startX + 4, startY + 3);
            DrawRect(startX , startY - 3, startX + 3, startY);
        }
    }
}
