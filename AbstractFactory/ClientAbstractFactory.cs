using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public static class ClientAbstractFactory
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("ABSTRACT FACTORY\n\n");

            IWidgetFactory widgetFactory;

            widgetFactory = new MotifWidgetFactory();
            Console.WriteLine("\tMotif Widget:");

            widgetFactory.CreateScrollBar().ScrollTo(30);
            widgetFactory.CreateWindow().Draw();

            Console.WriteLine("\n\n");

            widgetFactory = new PMWidgetFactory();
            Console.WriteLine("\tPresentation Manager Widget:");

            widgetFactory.CreateScrollBar().ScrollTo(30);
            widgetFactory.CreateWindow().Draw();
        }
    }
}
