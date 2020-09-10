using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PMScrollBar : IScrollBar
    {
        public void ScrollTo(int position)
        {
            Console.WriteLine(new string('_', position));
        }
    }
}
