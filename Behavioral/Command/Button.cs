using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class Button
    {
        private ICommand _command;

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }

    }
}
