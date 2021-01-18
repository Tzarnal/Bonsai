using System.Collections;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public class RandomTableMixed : RandomGenerator, IEnumerable<RandomGenerator>
    {
        private readonly List<RandomGenerator> _entries = new();

        public void Add(string entry)
        {
            _entries.Add(new BonsaiString(entry));
        }

        public void Add(RandomGenerator entry)
        {
            _entries.Add(entry);
        }

        public IEnumerator<RandomGenerator> GetEnumerator()
        {
            return _entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return _entries.RandomElement().ToString();
        }
    }
}