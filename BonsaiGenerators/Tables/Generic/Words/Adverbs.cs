namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class Adverbs : RandomGenerator
    {
        public static readonly RandomTable words = new()
        {
            "Beautifully",
            "Brightly",
            "Brutally",
            "Certainly",
            "Delicately",
            "Deliciously",
            "Delightfully",
            "Dramatically",
            "Dutifully",
            "Eternally",
            "Every Day",
            "Everywhere",
            "Exactly",
            "Firmly",
            "Gladly",
            "Gloriously",
            "Justly",
            "Loudly",
            "Once",
            "Perfectly",
            "Promptyly",
            "Quickly",
            "Regretfully",
            "Silently",
            "Sometimes",
            "Sorrowfully",
            "Sternly",
            "Uneasily",
            "Wickedly",
            "Yearly",
        };

        public override string ToString()
        {
            return words.ToString();
        }
    }
}