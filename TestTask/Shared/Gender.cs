using System.ComponentModel.DataAnnotations;

namespace TestTask.Shared
{
    /// <summary>
    /// Перечисление гендеров
    /// </summary>
    public enum Gender
    {
        [Display(Name = "М")]
        Male,
        [Display(Name = "Ж")]
        Female
    }
}