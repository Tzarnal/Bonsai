using System;

namespace BonsaiGenerators
{
    public sealed class Genie
    {
        private static readonly Genie instance = new Genie();
        private Random _random;

        static Genie()
        {
        }

        private Genie()
        {
            _random = new Random();
        }

        public int Next(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }

        public void SetSeed(string seed)
        {
            var seedInt = seed.GetHashCode();
            _random = new Random(seedInt);
        }

        public static Genie Instance => instance;
    }
}