namespace TestTask.Server.Services
{
    
    /// <summary>
    /// Интерфейс, позволяющий изменить запись
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IChangeable<T>
    {
        /// <summary>
        /// Изменение записи divisionToChange
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Change(T item, T divisionToChange);
    }
}