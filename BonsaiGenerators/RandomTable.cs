using System.Collections;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public class RandomTable : RandomGenerator, IEnumerable<string>
    {
        private readonly List<string> _entries = new();

        public void Add(string entry)
        {
            _entries.Add(entry);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return _entries.RandomElement();
        }
    }
}