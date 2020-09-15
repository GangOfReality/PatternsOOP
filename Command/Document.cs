using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Document
    {
        public void Open()
        {
            Console.WriteLine("Document opened");
        }
        public void Close()
        {
            Console.WriteLine("Document closed");
        }
        public void Copy()
        {
            Console.WriteLine("Document copied");
        }
        public void Paste()
        {
            Console.WriteLine("Document pasted");
        }
    }
}
