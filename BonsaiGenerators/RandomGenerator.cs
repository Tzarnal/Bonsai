using System;

namespace BonsaiGenerators
{
    public abstract class RandomGenerator
    {
        public override abstract string ToString();

        public string Next()
        {
            return ToString();
        }
    }
}