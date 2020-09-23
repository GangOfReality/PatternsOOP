using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Character : IElement
    {
        public Character(char character)
        {
            this.character = character;
        }
        public readonly char character;
        
        public void Draw()
        {
            Console.Write(character);
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitCharacter(this);
        }
    }
}
