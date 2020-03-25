using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Button : UIControl
    {
        public Button(DialogBox owner) : base(owner)
        {
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                _owner.Changed(this);
            }
        }
    }
}
