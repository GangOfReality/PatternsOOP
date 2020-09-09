using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Decorator : IVisualComponent
    {
        public Decorator(IVisualComponent component)
        {
            this.Component = component;
        }
        IVisualComponent Component;
        public virtual void Draw()
        {
            Component.Draw();
        }
    }
}
