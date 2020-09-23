using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IElement
    {
        void Draw();
        void Accept(Visitor visitor);
    }
}
