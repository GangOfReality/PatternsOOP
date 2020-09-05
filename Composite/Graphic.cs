using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class Graphic
    {
        public Graphic Parent;
        public abstract void Draw();
        public virtual void Add(Graphic graphic)
        {
            throw new Exception();
        }
        public virtual void Remove(Graphic graphic)
        {
            throw new Exception();
        }
        public virtual Graphic GetChild(int i)
        {
            throw new Exception();
        }
        public Graphic GetParent()
        {
            return Parent;
        }
    }
}
