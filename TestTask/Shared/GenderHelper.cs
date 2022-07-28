using System.ComponentModel.DataAnnotations;

namespace TestTask.Shared
{
    /// <summary>
    /// Класс-помощник для перечисления Gender
    /// </summary>
    public static class GenderHelper
    {
        /// <summary>
        /// Получает наименование гендера
        /// </summary>
        /// <param name="gender">Гендер, наименование которого нужно получить</param>
        public static string GetGenderTitle(Gender gender)
        {
            return gender.GetAttribute<DisplayAttribute>().Name;
        }
    }
}