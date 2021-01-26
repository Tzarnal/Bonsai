using System;

namespace BonsaiGenerators
{
    public sealed class Genie
    {
        private static Random _random;

        private static void EnsureInstance()
        {
            if (_random == null)
            {
                Console.WriteLine("EnsureInstance Fired");
                _random = new Random();
            }
        }

        public static int Next(int maxValue)
        {
            EnsureInstance();

            return _random.Next(maxValue);
        }

        public static int Next(int minValue, int maxValue)
        {
            EnsureInstance();

            return _random.Next(minValue, maxValue);
        }

        public static void SetSeed(string seed)
        {
            var seedInt = seed.GetAsciiValueSum();
            _random = new Random(seedInt);

            Console.WriteLine("New random. Seed: " + seed);
        }
    }
}