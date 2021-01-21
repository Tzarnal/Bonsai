namespace BonsaiGenerators.Tables.Names.Real.Template
{
    internal class TemplateFamily : RandomGenerator
    {
        public static readonly RandomTable FamilyNames = new()
        {
            "",
        };

        public override string ToString()
        {
            return FamilyNames.Next();
        }
    }
}