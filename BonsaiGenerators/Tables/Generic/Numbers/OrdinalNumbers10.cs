namespace BonsaiGenerators.Tables.Generic.Numbers
{
    internal class OrdinalNumbers10 : RandomGenerator
    {
        public static readonly RandomTable Numbers = new()
        {
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Sixth",
            "Seventh",
            "Eighth",
            "Ninth",
            "Tenth",
        };

        public override string ToString()
        {
            return Numbers.Next();
        }
    }
}