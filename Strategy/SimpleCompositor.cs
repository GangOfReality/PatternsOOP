using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SimpleCompositor : Compositor
    {
        public override void Compose()
        {
            var components = base.composition.Components;
            int bound = 0;
            base.lineBreaks = new List<int>();

            foreach(var component in components)
            {
                bound += component.Width;
                if(bound > 8)
                {
                    bound -= component.Width;
                    base.lineBreaks.Add(bound);
                    bound = component.Width;
                }
            }

            base.composition.Traverse(base.lineBreaks);
        }
    }
}
