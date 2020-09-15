using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Application
    {
        public List<Document> Documents { get; private set; } = new List<Document>();
        public List<MenuItem> MenuItems { get; private set; } = new List<MenuItem>();

        public void AddDocument(Document document)
        {
            this.Documents.Add(document);
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
        }
    }
}
