using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators
{
    public class BonsaiString : RandomGenerator
    {
        private readonly string _content;

        public BonsaiString(string content)
        {
            _content = content;
        }

        public override string ToString()
        {
            return _content;
        }
    }
}