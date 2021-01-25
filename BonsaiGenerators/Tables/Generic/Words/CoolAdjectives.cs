using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class CoolAdjectives : RandomGenerator
    {
        public static readonly RandomTable words = new()
        {
            "Ancient",
            "Ardent",
            "Ashen",
            "Bloody",
            "Bright",
            "Brusk",
            "Burning",
            "Celebrated",
            "Cherished",
            "Cold",
            "Dark",
            "Divine",
            "Docile",
            "Ebon",
            "Empty",
            "Endless",
            "Eternal",
            "Failed",
            "Famed",
            "Fragrant",
            "Frozen",
            "Furious",
            "Gentle",
            "Gifted",
            "Gilded",
            "Grand",
            "Heavenly",
            "Hidden",
            "Hopeful",
            "Hot",
            "Immortal",
            "Infinite",
            "Jade",
            "Juggernaut",
            "Liminal",
            "Masked",
            "Painful",
            "Paper",
            "Pure",
            "Recursive",
            "Shining",
            "Silent",
            "Silk",
            "Sleeping",
            "Sorrowful",
            "Sweet",
            "Turbulent",
            "Verdant",
            "Vigilant",
            "Wilful",
            "Radiant",
        };

        public override string ToString()
        {
            return words.ToString();
        }
    }
}