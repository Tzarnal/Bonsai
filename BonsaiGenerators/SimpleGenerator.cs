using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators
{
    public class SimpleGenerator : RandomGenerator
    {
        public override string ToString()

        {
            var Event = new RandomTable
            {
                "the Fall Equinox",
                "the Spring Equinox",
                "the winter Solstice",
                "the summer Solstice",
                "the summer Olympics",
                "the winter Olympics",
                "daylight saving time",
                "daylight savings time",
                "leap day",
                "leap year",
                "the harvest moon",
                "the super moon",
                "the blood moon",
                "Toyota truck month",
                "shark week"
            };

            return $"{Event}";
        }
    }
}