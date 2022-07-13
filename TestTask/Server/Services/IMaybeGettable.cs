using Microsoft.AspNetCore.Http;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий получить запись из бд по идентификатору, если такая запись есть
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMaybeGettable<T>
    {
        /// <summary>
        /// Попытка получить запись из бд по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns>true если запись по ид найдена. false, если нет</returns>
        bool TryGet(int id, out T value);
    }
}