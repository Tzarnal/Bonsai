namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class AgitatedCalmAdjectives : RandomGenerator
    {
        public static readonly RandomTable words = new()
        {
            "Abating",
            "Calm",
            "Calming",
            "Churning",
            "Clear",
            "Clouded",
            "Driving",
            "Dwindeling",
            "Ebbing",
            "Fair",
            "Falling",
            "Halcyon",
            "Holy",
            "Hushed",
            "Loud",
            "Quiet",
            "Raging",
            "Receding",
            "Reeling",
            "Relenting",
            "Relentless",
            "Roiling",
            "Seething",
            "Serene",
            "Silent",
            "Sinking",
            "Still",
            "Subsiding",
            "Sullen",
            "Swirling",
            "Tranquil",
            "Unholy",
            "Vile",
            "Whirling",
            "Wispering",
        };

        public override string ToString()
        {
            return words.ToString();
        }
    }
}