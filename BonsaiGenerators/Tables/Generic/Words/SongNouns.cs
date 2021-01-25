namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class SongNouns : RandomGenerator
    {
        public static readonly RandomTable words = new()
        {
            "Anthem",
            "Aria",
            "Art",
            "Ballad",
            "Ballad",
            "Cantata",
            "Canticle",
            "Dirge",
            "Echo",
            "Elegy",
            "Fable",
            "Fantasy",
            "Hymn",
            "Lament",
            "Legend",
            "Legend",
            "Myth",
            "Ode",
            "Parable",
            "Poem",
            "Psalm",
            "Romance",
            "Saga",
            "Song",
            "Sonnet",
            "Sound",
            "Story",
            "Tale",
            "Tale",
            "Truth",
            "Verse",
        };

        public override string ToString()
        {
            return words.ToString();
        }
    }
}