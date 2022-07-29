using System;
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
        /// Получает атрибут перечисления
        /// </summary>
        /// <typeparam name="TAttribute">Тип атрибута</typeparam>
        /// <param name="value">Перечисление, атрибут которого нужно найти</param>
        public static TAttribute GetAttribute<TAttribute>(this Enum value)
            where TAttribute : Attribute
        {
            return value.GetType().GetMember(value.ToString()).First().GetCustomAttribute<TAttribute>();
        }
    }
}