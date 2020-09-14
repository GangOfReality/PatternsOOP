using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class XWindowImp : IWindowImp
    {
        public void DevDrawLine(int startX, int startY, int length, bool isVertical = false)
        {
            Console.SetCursorPosition(startX, startY);
            if (isVertical)
            {
                for (int i = 0; i <= length; i++)
                {
                    Console.Write('*');
                    Console.SetCursorPosition(startX, startY + i);
                }
            }
            else
            {
                Console.WriteLine(new string('*', length));
            }
        }

        public void DevDrawText(int startX, int startY, string text)
        {
            Console.SetCursorPosition(startX, startY);
            Console.WriteLine(text);
        }
    }
}
