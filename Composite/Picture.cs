using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// This class is composite of leaf classes.
    /// Have the children, what is part of composite.
    /// Agregation relationship.
    /// </summary>
    class Picture : Graphic
    {
        private List<Graphic> children = new List<Graphic>();
        public override void Add(Graphic graphic)
        {
            graphic.Parent = this;
            children.Add(graphic);
        }

        public override void Draw()
        {
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public override Graphic GetChild(int i)
        {
            return children[i];
        }

        public override void Remove(Graphic graphic)
        {
            graphic.Parent = null;
            children.Remove(graphic);
        }
    }
}
