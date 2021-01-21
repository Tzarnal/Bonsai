using BonsaiGenerators.Tables.Names.Real.Dutch;

namespace BonsaiGenerators.Content
{
    public class DutchNames : RandomNameGenerator
    {
        private static readonly RandomGenerator FamilyName = new DutchFamilyNames();
        private static readonly RandomGenerator MaleGivenName = new DutchMaleGiven();
        private static readonly RandomGenerator FemaleGivenName = new DutchFemaleGiven();

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