using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MotifWidgetFactory : IWidgetFactory
    {
        public IScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }

        public IWindow CreateWindow()
        {
            return new MotifWindow();
        }
    }
}
