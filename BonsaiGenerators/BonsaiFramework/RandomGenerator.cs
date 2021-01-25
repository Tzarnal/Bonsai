using System;

namespace BonsaiGenerators
{
    public abstract class RandomGenerator
    {
        public override abstract string ToString();

        public string Next(string seed = "")
        {
            if (seed != "")
            {
                Genie.Instance.SetSeed(seed);
            }

            return ToString();
        }
    }
}