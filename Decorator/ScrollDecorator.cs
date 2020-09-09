using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ScrollDecorator : Decorator
    {
        private readonly int scrollPosition;
        public ScrollDecorator(IVisualComponent Component, int scrollPosition) : base(Component)
        {
            this.scrollPosition = scrollPosition;
        }
        public override void Draw()
        {
            this.ScrollTo(scrollPosition);
            base.Draw();
        }
        private void ScrollTo(int position)
        {
            Console.SetCursorPosition(position, Console.CursorTop);

            //Console.Write(new string(' ', position));

            //var cursorLeft = Console.CursorLeft;
            //Console.SetCursorPosition(0, Console.CursorTop);
            //Console.Write(new string(' ', position));
            //Console.SetCursorPosition(cursorLeft + position, Console.CursorTop);
        }
    }
}
