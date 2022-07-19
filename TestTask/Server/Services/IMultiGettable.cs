using System.Collections.Generic;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий получить список данных
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMultiGettable<T>
    {
        /// <summary>
        /// Получение списка данных
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> Get();
    }
}