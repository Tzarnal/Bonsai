using System;

namespace BonsaiGenerators
{
    public sealed class Genie
    {
        private static readonly Genie instance = new Genie();
        private readonly Random _random;

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

        public static Genie Instance => instance;
    }
}