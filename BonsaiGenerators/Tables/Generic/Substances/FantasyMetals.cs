namespace BonsaiGenerators.Tables.Generic.Substances
{
    internal class FantasyMetals : RandomGenerator
    {
        public static readonly RandomTable materials = new()
        {
            "Mithril",
            "Orichalcum",
            "Adamantium",
            "Moonsilver",
            "Soulsteel",
            "Starmetal",
            "Cold-Iron",
            "Meteor-Iron",
        };

        public override string ToString()
        {
            return materials.Next();
        }
    }
}