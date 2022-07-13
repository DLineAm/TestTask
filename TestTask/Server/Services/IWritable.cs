namespace TestTask.Server.Services
{
    /// <summary>
    /// Интерфейс, позволяющий изменять запись (добавление в бд, удаление из бд по идентификатору и изменение)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWritable<T> : IAddable<T>, IChangeable<T>, IDeletable<T>{}
}