using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonsaiGenerators
{
    internal static class Extensions
    {
        public static T RandomElement<T>(this List<T> list)
        {
            var genie = Genie.Instance;
            return list[genie.Next(0, list.Count)];
        }

        public static TKey RandomElementWeighted<TKey>(this Dictionary<TKey, int> dictionary)
        {
            var genie = Genie.Instance;
            TKey element = dictionary.FirstOrDefault().Key;

            var totalWeight = dictionary.Sum(kvp => kvp.Value);
            var r = genie.Next(totalWeight);

            foreach (var (key, value) in dictionary)
            {
                if (r >= value)
                {
                    r -= value;
                }
                else
                {
                    element = key;
                    break;
                }
            }

            return element;
        }
    }
}