using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class CloseCommand : ICommand
    {
        public Document Document;
        public CloseCommand(Document document)
        {
            this.Document = document;
        }
        public void Execute()
        {
            Document.Close();
        }
    }
}
