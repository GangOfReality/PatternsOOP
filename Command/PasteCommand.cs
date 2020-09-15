using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class PasteCommand : ICommand
    {
        public Document Document;
        public PasteCommand(Document document)
        {
            this.Document = document;
        }
        public void Execute()
        {
            Document.Paste();
        }
    }
}
