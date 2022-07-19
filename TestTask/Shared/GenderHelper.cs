using System;
using System.Collections.Generic;

namespace TestTask.Shared
{
    public static class GenderHelper
    {
        public static Gender[] GetGenders()
        {
            return new[] {Gender.Male, Gender.Female};
        }

        public static string GetGenderTitle(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "М",
                Gender.Female => "Ж",
                _ => throw new ArgumentOutOfRangeException(nameof(gender), gender, null)
            };
        }
    }
}