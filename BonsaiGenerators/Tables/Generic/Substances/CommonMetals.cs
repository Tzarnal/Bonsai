namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class CommonMetals : RandomGenerator
    {
        public static readonly RandomTable materials = new()
        {
            "iron",
            "steel",
            "copper",
            "bronze",
            "brass",
            "silver",
            "gold",
            "platinum",
            "iridium",
            "antimony",
            "mercury",
            "cobalt",
            "titanium",
            "chrome",
        };

        public override string ToString()
        {
            return materials.Next();
        }
    }
}