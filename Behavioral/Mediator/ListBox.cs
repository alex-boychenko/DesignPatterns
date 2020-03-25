using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class ListBox : UIControl
    {
        public ListBox(DialogBox owner) : base(owner)
        {
        }

        private string _selection;

        public string Selection
        {
            get { return _selection; }
            set 
            { 
                _selection = value;
                _owner.Changed(this);
            }
        }
    }
}
