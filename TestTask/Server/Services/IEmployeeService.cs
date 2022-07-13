using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис сотрудников
    /// </summary>
    public interface IEmployeeService : IMaybeGettable<Employee>, IGettableWithParameter<Employee>, IWritable<Employee>{}
}