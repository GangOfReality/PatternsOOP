using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public static class ClientComposite
    {
        public static void ExecuteScript()
        {
            List<Graphic> graphics = new List<Graphic>();

            graphics.Add(new Text());
            graphics.Add(new Line());

            Graphic picture = new Picture();
            picture.Add(new Rectangle());
            picture.Add(new Line());
            picture.Add(new Text());

            graphics.Add(picture);

            foreach (var graphic in graphics)
            {
                graphic.Draw();
            }
        }
    }
}
