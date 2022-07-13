using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис подразделений
    /// </summary>
    public interface IDivisionService : IMultiGettable<Division>, IMaybeGettable<Division>, IWritable<Division>
    {
    }
}