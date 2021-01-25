namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class FancyMaterials : RandomGenerator
    {
        public static readonly RandomTable materials = new()
        {
            "Jade",
            "Silk",
            "Gossamer",
            "Verdigris",
            "Peony",
            "Feather",
            "Saffron",
            "Luminiferous",
            "Pearl",
        };

        public override string ToString()
        {
            return materials.Next();
        }
    }
}