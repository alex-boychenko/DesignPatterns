using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Directory : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        private readonly string _name;
        public Directory(string name)
        {
            _name = name;
        }
        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);

            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
