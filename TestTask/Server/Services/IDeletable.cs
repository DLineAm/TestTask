namespace TestTask.Server.Services
{
    
    /// <summary>
    /// Интерфейс, позволяющий удалить запись
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeletable<T>
    {
        /// <summary>
        /// Удаление записи из базы данных
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Delete(T item);
    }
}