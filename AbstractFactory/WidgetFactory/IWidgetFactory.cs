using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IWidgetFactory
    {
        IScrollBar CreateScrollBar();
        IWindow CreateWindow();
    }
}
