using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class File : IComponent
    {
        private readonly string _name;
        public File(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);
        }
    }
}
