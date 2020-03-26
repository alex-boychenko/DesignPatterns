using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class EditorState
    {
        public string Content { get; private set; }

        public EditorState(string content)
        {
            Content = content;
        }
    }
}
