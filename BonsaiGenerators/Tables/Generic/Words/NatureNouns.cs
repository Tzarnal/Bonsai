namespace BonsaiGenerators.Tables.Generic.Words
{
    internal class NatureNouns : RandomGenerator
    {
        public static readonly RandomTable words = new()
        {
            "Autumn",
            "Clouds",
            "Dawn",
            "Dusk",
            "Fall",
            "Fog",
            "Gale",
            "Hail",
            "Lightning",
            "Mist",
            "Mistral",
            "Mists",
            "Monsoon",
            "Moon",
            "Moons",
            "Night",
            "Rain",
            "River",
            "Sleet",
            "Smoke",
            "Snow",
            "Spring",
            "Stars",
            "Storm",
            "Stream",
            "Summer",
            "Sun",
            "Suns",
            "Thunder",
            "Vapor",
            "Water",
            "Waters",
            "Waves",
            "Wind",
            "Winter",
        };

        public override string ToString()
        {
            return words.ToString();
        }
    }
}