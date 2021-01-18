using System.Collections.Generic;
using System.Collections;

namespace BonsaiGenerators
{
    public class RandomTableMixedWeighted : RandomGenerator, IEnumerable<KeyValuePair<RandomGenerator, int>>
    {
        private readonly Dictionary<RandomGenerator, int> _entries = new();

        public void Add(string key, int value = 1)
        {
            _entries.Add(new BonsaiString(key), value);
        }

        public void Add(RandomGenerator key, int value = 1)
        {
            _entries.Add(key, value);
        }

        public IEnumerator<KeyValuePair<RandomGenerator, int>> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return _entries.RandomElementWeighted().ToString();
        }
    }
}