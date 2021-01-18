using System.Collections;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public class RandomTableWeighted : RandomGenerator, IEnumerable<KeyValuePair<string, int>>
    {
        private readonly Dictionary<string, int> _entries = new();

        public void Add(string key, int value)
        {
            _entries.Add(key, value);
        }

        public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return _entries.RandomElementWeighted();
        }
    }
}