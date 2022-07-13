using System.Collections.Generic;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий получить список из бд
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMultiGettable<T>
    {
        /// <summary>
        /// Получение списка из бд
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();
    }
}