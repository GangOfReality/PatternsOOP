using System;
using System.Collections.Generic;
using System.Text;

using Composite;

namespace Strategy
{
    public class Composition
    {
        private Compositor compositor;
        public List<Component> Components { get; private set; } = new List<Component>();
        private Queue<int> lineBreaks;
        public Composition(Compositor compositor)
        {
            SetCompositor(compositor);
        }
        public void SetCompositor(Compositor compositor)
        {
            this.compositor = compositor;
            this.compositor.SetComposition(this);
        }
        public void Traverse(IEnumerable<int> lineBreaks)
        {
            this.lineBreaks = new Queue<int>(lineBreaks);
        }
        public void Repair()
        {
            compositor.Compose();
        }
        public void AddComponent(Component component)
        {
            Components.Add(component);
        }
        public void Draw()
        {
            int currentPosition = 0;
            foreach (var component in Components)
            {
                if(lineBreaks.Peek() < currentPosition + component.Width)
                {
                    Console.WriteLine();
                    lineBreaks.Dequeue();
                    if (lineBreaks.Count == 0)
                        lineBreaks.Enqueue(int.MaxValue);
                    currentPosition = 0;
                }
                Console.Write(component.Character);
                Console.Write(new string('_', component.Width - 1));
                currentPosition += component.Width;
            }
        }
    }
}
