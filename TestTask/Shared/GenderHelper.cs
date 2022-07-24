using System;
using System.Collections.Generic;

namespace TestTask.Shared
{
    public static class GenderHelper
    {
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