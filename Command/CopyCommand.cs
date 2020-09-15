using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CopyCommand : ICommand
    {
        public Document Document;
        public CopyCommand(Document document)
        {
            this.Document = document;
        }
        public void Execute()
        {
            Document.Copy();
        }
    }
}
