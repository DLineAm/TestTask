using System.Collections.Generic;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий получить спискок из бд по параметру
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGettableWithParameter<T>{
        /// <summary>
        /// Получение списка из бд по параметру
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<T> GetWithParameter(object param);
    }
}