using BonsaiGenerators;
using BonsaiGenerators.Tables.Names.Real.Dutch;

namespace BonsaiGenerators.Content
{
    public class DutchNames : RandomGenerator
    {
        private static readonly RandomGenerator FamilyName = new DutchFamilyNames();
        private static readonly RandomGenerator MaleGivenName = new DutchMaleGiven();
        private static readonly RandomGenerator FemaleGivenName = new DutchFemaleGiven();

        private static readonly RandomGenerator GivenName = new RandomTableMixed
        {
            MaleGivenName,
            FemaleGivenName
        };

        public override string ToString()
        {
            return $"{GivenName} {FamilyName}";
        }

        public static string FirstNameFemale()
        {
            return FemaleGivenName.Next();
        }

        public static string FirstNameMale()
        {
            return MaleGivenName.Next();
        }

        public static string FirstName()
        {
            return GivenName.Next();
        }

        public static string LastName()
        {
            return FamilyName.Next();
        }
    }
}