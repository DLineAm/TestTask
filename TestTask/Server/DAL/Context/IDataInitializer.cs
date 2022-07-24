namespace TestTask.Server.DAL.Context
{
    /// <summary>
    /// Интерфейс, определяющий инициализатора данных
    /// </summary>
    public interface IDataInitializer
    {
        void Initialize(DatabaseContext context);
    }
}