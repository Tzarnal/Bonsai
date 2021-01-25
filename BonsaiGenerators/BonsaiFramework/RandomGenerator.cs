using System;
using System.Collections.Generic;

namespace BonsaiGenerators
{
    public abstract class RandomGenerator
    {
        public override abstract string ToString();

        public string Next(string Seed = "")
        {
            if (Seed != "")
            {
                Genie.Instance.SetSeed(Seed);
            }

            return ToString();
        }

        public string DynamicInterpolation(List<(string, RandomGenerator)> Replacements, string Seed = "")
        {
            return DynamicInterpolation(Next(Seed), Replacements);
        }

        public static string DynamicInterpolation(string input, List<(string, RandomGenerator)> Replacements)
        {
            foreach (var (key, generator) in Replacements)
            {
                while (input.Contains(key))
                {
                    input = input.ReplaceFirst(key, generator.Next());
                }
            }

            return input.CapitalizeFirstChar();
        }
    }
}