using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class UIControl
    {
        protected readonly DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }
}
