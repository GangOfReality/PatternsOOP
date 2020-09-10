using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PMWidgetFactory : IWidgetFactory
    {
        public IScrollBar CreateScrollBar()
        {
            return new PMScrollBar();
        }

        public IWindow CreateWindow()
        {
            return new PMWindow();
        }
    }
}
