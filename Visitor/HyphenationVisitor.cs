using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class HyphenationVisitor : Visitor
    {
        public override IEnumerable<string> GetElements()
        {
            throw new NotImplementedException();
        }

        public override void VisitCharacter(Character character)
        {
            throw new NotImplementedException();
        }

        public override void VisitRow(Row row)
        {
            throw new NotImplementedException();
        }
    }
}
