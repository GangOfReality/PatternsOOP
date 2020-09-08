using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Compositor
    {
        protected Composition composition;
        protected List<int> lineBreaks;
        public void SetComposition(Composition composition)
        {
            this.composition = composition;
        }
        public abstract void Compose();
    }
}
