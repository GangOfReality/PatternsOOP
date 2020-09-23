using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Row : IElement
    {
        public Row(IEnumerable<IElement> row)
        {
            this.row = row;
        }
        private IEnumerable<IElement> row;
        public void Accept(Visitor visitor)
        {
            visitor.VisitRow(this);
        }

        public void Draw()
        {
            foreach(var character in row)
            {
                character.Draw();
            }
        }
    }
}
