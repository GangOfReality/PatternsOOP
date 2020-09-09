using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BorderDecorator : Decorator
    {
        private readonly int borderWidth;
        public BorderDecorator(IVisualComponent Component, int borderWidth) : base(Component)
        {
            this.borderWidth = borderWidth;
        }
        public override void Draw()
        {
            this.DrawBorder();
            base.Draw();
        }
        private void DrawBorder()
        {
            var cursorLeft = Console.CursorLeft;
            Console.SetCursorPosition(cursorLeft, Console.CursorTop - 1);
            Console.Write(new string('-', borderWidth + 2));
            Console.SetCursorPosition(cursorLeft, Console.CursorTop + 2);
            Console.Write(new string('-', borderWidth + 2));
            Console.SetCursorPosition(cursorLeft, Console.CursorTop - 1);
            Console.Write('|');
            Console.SetCursorPosition(cursorLeft + borderWidth + 1, Console.CursorTop);
            Console.Write('|');
            Console.SetCursorPosition(cursorLeft + 1, Console.CursorTop);
        }
    }
}
