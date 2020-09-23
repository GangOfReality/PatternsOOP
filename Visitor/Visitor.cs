using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    abstract class Visitor
    {
        public abstract void VisitCharacter(Character character);
        public abstract void VisitRow(Row row);
        public abstract IEnumerable<string> GetElements();
    }
}
