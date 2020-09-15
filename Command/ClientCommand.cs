using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public static class ClientCommand
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("COMMAND\n\n");

            Application application = new Application();
            application.AddDocument(new Document());

            application.AddMenuItem(new MenuItem(new CopyCommand(application.Documents[0])));
            application.AddMenuItem(new MenuItem(new PasteCommand(application.Documents[0])));
            application.AddMenuItem(new MenuItem(new OpenCommand(application.Documents[0])));
            application.AddMenuItem(new MenuItem(new CloseCommand(application.Documents[0])));

            foreach(var item in application.MenuItems)
            {
                item.OnClicked();
            }

        }
    }
}
