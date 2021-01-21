namespace BonsaiGenerators.Tables.Names.Fantasy.Dragonborn
{
    internal class DragonbornFamily : RandomGenerator
    {
        public static readonly RandomTable Fragment1 = new()
        {
            "Blood",
            "Gore",
            "Bile",
            "Drake",
            "Dragon",
            "Wyrm",
            "Whelp",
            "Flame",
            "Hammer",
            "Anvil",
            "Lore",
            "Page",
            "History",
            "Moon",
            "Sun",
            "Star",
            "Peace",
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Black",
            "White",
            "Grey",
            "Silver",
            "Gold",
            "Steel",
            "Iron",
            "Bronze",
            "Copper",
            "Spell",
            "Magic",
            "Scrap",
            "Punch",
            "War",
        };

        public static readonly RandomTable Fragment2 = new()
        {
            "bane",
            "rider",
            "brow",
            "wing",
            "mark",
            "scale",
            "plate",
            "armor",
            "blade",
            "axe",
            "sword",
            "arrow",
            "talon",
            "fang",
            "claw",
            "mark",
            "spear",
            "scale",
            "bringer",
        };

        public override string ToString()
        {
            return $"{Fragment1}{Fragment2}";
        }
    }
}