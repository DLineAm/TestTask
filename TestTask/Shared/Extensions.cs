using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace TestTask.Shared
{
    /// <summary>
    /// Класс, хранящий вспомогательные методы
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Получает наименование гендера
        /// </summary>
        /// <param name="gender">Гендер, наименование которого нужно получить</param>
        public static string GetDisplayTitle(this Enum gender)
        {
            return gender.GetAttribute<DisplayAttribute>()?.Name ?? string.Empty;
        }

        /// <summary>
        /// Получает атрибут перечисления
        /// </summary>
        /// <typeparam name="TAttribute">Тип атрибута</typeparam>
        /// <param name="value">Перечисление, атрибут которого нужно найти</param>
        private static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            return value.GetType().GetMember(value.ToString()).First().GetCustomAttribute<TAttribute>();
        }

       
    }
}