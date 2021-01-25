namespace BonsaiGenerators.Tables.Generic.Colours
{
    internal class Colours16 : RandomGenerator
    {
        public static readonly RandomTable colours = new()
        {
            "white",
            "black",
            "gray",
            "maroon",
            "red",
            "crimson",
            "orange",
            "yellow",
            "green",
            "lime",
            "blue",
            "teal",
            "purple",
            "brown",
            "olive",
            "pink",
        };

        public override string ToString()
        {
            return colours.Next();
        }
    }
}