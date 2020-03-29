using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
