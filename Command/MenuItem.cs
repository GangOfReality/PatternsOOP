using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    delegate void MyEventHandler();
    class MenuItem
    {
        public ICommand command;
        public event MyEventHandler Clicked;

        public MenuItem(ICommand command)
        {
            this.command = command;
            Clicked = () => command.Execute();
        }

        public void OnClicked()
        {
            Clicked?.Invoke();
        }
    }
}
