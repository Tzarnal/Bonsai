namespace BonsaiGenerators.Tables.Names.Real.Template
{
    internal class TemplateFemaleGiven : RandomGenerator
    {
        public static readonly RandomTable FemaleGivenNames = new()
        {
            "",
        };

        public override string ToString()
        {
            return FemaleGivenNames.Next();
        }
    }
}