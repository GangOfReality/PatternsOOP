using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ArrayCompositor : Compositor
    {
        public override void Compose()
        {
            var components = base.composition.Components;
            int i = 0;
            base.lineBreaks = new List<int>();

            foreach(var component in components)
            {
                i += 4;
                base.lineBreaks.Add(i);
            }

            base.composition.Traverse(base.lineBreaks);
        }
    }
}
