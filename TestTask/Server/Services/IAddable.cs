namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий добавить запись в бд
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAddable<T>
    {
        /// <summary>
        /// Добавление записи в бд
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
    }
}