using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        private string _content;

        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }
    }
}
