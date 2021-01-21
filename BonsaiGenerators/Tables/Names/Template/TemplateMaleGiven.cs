namespace BonsaiGenerators.Tables.Names.Real.Template
{
    internal class TemplateMaleGiven : RandomGenerator
    {
        public static readonly RandomTable MaleGivenNames = new()
        {
            "",
        };

        public override string ToString()
        {
            return MaleGivenNames.Next();
        }
    }
}