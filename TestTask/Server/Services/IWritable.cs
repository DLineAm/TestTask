namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий изменять запись
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWritable<T>
    {
        void Add(T item);
        void Change(T item);
        void Delete(int Id);
    }
}