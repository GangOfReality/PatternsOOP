using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// This class is a sample for Component.
    /// Declare interface for parent classes, and implement common methods.
    /// May contains link to parent OBJECT (composite object).
    /// </summary>
    public abstract class Graphic
    {
        public Graphic Parent;

        // Specific method for each class
        public abstract void Draw();

        // Common methods of working with children
        // Will be override in Composite class
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

        // Common method of every classes.
        public Graphic GetParent()
        {
            return Parent;
        }
    }
}
