using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MotifScrollBar : IScrollBar
    {
        public void ScrollTo(int position)
        {
            Console.WriteLine(new string('*', position));
        }
    }
}
