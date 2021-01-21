using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators
{
    public abstract class RandomNameGenerator : RandomGenerator
    {
        public abstract string FullName();

        public abstract string FemaleFullName();

        public abstract string MaleFullName();
    }
}