namespace TestTask.Shared
{
    /// <summary>
    /// Интерфейс, представляющий идентификатор для записей
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        int Id { get; set; }
    }
}