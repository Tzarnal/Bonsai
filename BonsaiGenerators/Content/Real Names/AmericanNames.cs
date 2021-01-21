using BonsaiGenerators.Tables.Names.Real.American;

namespace BonsaiGenerators.Content
{
    public class AmericanNames : RandomNameGenerator
    {
        private static readonly RandomGenerator FamilyName = new AmericanFamily();
        private static readonly RandomGenerator MaleGivenName = new AmericanMaleGiven();
        private static readonly RandomGenerator FemaleGivenName = new AmericanFemaleGiven();

        private static readonly RandomGenerator GivenName = new RandomTableMixed
        {
            MaleGivenName,
            FemaleGivenName
        };

        public override string FullName()
        {
            return ToString();
        }

        public override string FemaleFullName()
        {
            return $"{FemaleGivenName} {FamilyName}";
        }

        public override string MaleFullName()
        {
            return $"{MaleGivenName} {FamilyName}";
        }

        public override string ToString()
        {
            return $"{GivenName} {FamilyName}";
        }
    }
}