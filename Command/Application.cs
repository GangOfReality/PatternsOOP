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
        public void InitializeMenu(int documentNumber)
        {
            AddMenuItem(new MenuItem(new CopyCommand(Documents[documentNumber])));
            AddMenuItem(new MenuItem(new PasteCommand(Documents[documentNumber])));
            AddMenuItem(new MenuItem(new OpenCommand(Documents[documentNumber])));
            AddMenuItem(new MenuItem(new CloseCommand(Documents[documentNumber])));
        }
    }
}
