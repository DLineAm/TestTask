using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Класс, имеющий хранилища списков записей
    /// </summary>
    public class Cache
    {
        /// <summary>
        /// Конструктор, принимающий хранилища в качестве параметров
        /// </summary>
        public Cache(IStorage<Division> divisionStorage, IStorage<Employee> employeeStorage)
        {
            DivisionStorage = divisionStorage;
            EmployeeStorage = employeeStorage;
        }

        /// <summary>
        /// Хранилище списка подразделений
        /// </summary>
        public IStorage<Division> DivisionStorage { get; }

        /// <summary>
        /// Хранилище списка работников
        /// </summary>
        public IStorage<Employee> EmployeeStorage { get; }
    }
}