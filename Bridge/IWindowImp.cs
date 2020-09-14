using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IWindowImp
    {
        void DevDrawLine(int startX, int startY, int length, bool isVertical = false);
        void DevDrawText(int startX, int startY, string text);
    }
}
