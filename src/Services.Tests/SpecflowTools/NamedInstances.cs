using System;
using System.Collections.Generic;

namespace Services.Tests.SpecflowTools
{
    public class NamedInstances<T>
    {
        private readonly Dictionary<string, T> _dictionary = new Dictionary<string, T>();

        public T Ensure(string name, Func<T> factory)
        {
            return _dictionary.ContainsKey(name)
                ? _dictionary[name]
                : (_dictionary[name] = factory());
        }
    }
}