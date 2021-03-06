﻿using System.Collections.Generic;

namespace BonsaiGenerators.Tables.Generic.Colours
{
    internal class ColoursMany : RandomTable
    {
        public new List<string> Entries
        {
            get { return base.Entries; }

            set
            {
                base.Entries = value;
            }
        }

        public static readonly List<string> colours = new()
        {
            "amaranth",
            "amber",
            "amethyst",
            "apricot",
            "aquamarine",
            "azure",
            "baby blue",
            "beige",
            "black",
            "blue",
            "blue-green",
            "blue-violet",
            "blush",
            "bronze",
            "brown",
            "burgundy",
            "byzantium",
            "carmine",
            "cerise",
            "cerulean",
            "champagne",
            "chartreuse green",
            "chocolate",
            "cobalt blue",
            "coffee",
            "copper",
            "coral",
            "crimson",
            "cyan",
            "desert sand",
            "electric blue",
            "emerald",
            "erin",
            "gold",
            "gray",
            "green",
            "harlequin",
            "indigo",
            "ivory",
            "jade",
            "jungle green",
            "lavender",
            "lemon",
            "lilac",
            "lime",
            "magenta",
            "magenta rose",
            "maroon",
            "mauve",
            "navy blue",
            "ocher",
            "olive",
            "orange",
            "orange-red",
            "orchid",
            "peach",
            "pear",
            "periwinkle",
            "persian blue",
            "pink",
            "plum",
            "prussian blue",
            "puce",
            "purple",
            "raspberry",
            "red",
            "red-violet",
            "rose",
            "ruby",
            "salmon",
            "sangria",
            "apphire",
            "scarlet",
            "silver",
            "slate gray",
            "spring bud",
            "spring green",
            "tan",
            "taupe",
            "teal",
            "turquoise",
            "violet",
            "viridian",
            "white",
            "yellow",
        };

        public ColoursMany()
        {
            Entries = colours;
        }
    }
}