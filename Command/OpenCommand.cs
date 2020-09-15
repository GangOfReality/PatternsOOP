using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class OpenCommand : ICommand
    {
        public Document Document;
        public OpenCommand(Document document)
        {
            this.Document = document;
        }
        public void Execute()
        {
            Document.Open();
        }
    }
}
