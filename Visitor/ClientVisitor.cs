using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public static class ClientVisitor
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("VISITOR\n\n");

            List<IElement> elements = new List<IElement>() { 
                new Character('H'),
                new Character('e'),
                new Character('l'),
                new Character('l'),
                new Character('o'),
                new Character('_'),
                new Character('v'),
                new Character('i'),
                new Character('s'),
                new Character('i'),
                new Character('t'),
                new Character('o'),
                new Character('r'),
                new Character('_'),
                new Character('a'),
                new Character('A'),
                new Character('a'),
                new Character('A'),
                new Character('a'),
                new Character('.')
            };

            Visitor visitor = new RegisterCheckingVisitor();

            foreach (var element in elements)
            {
                element.Accept(visitor);
            }

            var misregisterElements = visitor.GetElements();
            foreach(var element in misregisterElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
