using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Класс, имеющий хранилища списков записей
    /// </summary>
    public class Cache
    {

        /// <summary>
        /// Хранилище списка подразделений
        /// </summary>
        public IStorage<Division> DivisionStorage { get; set; }

        /// <summary>
        /// Хранилище списка работников
        /// </summary>
        public IStorage<Employee> EmployeeStorage { get; set; }

        /// <summary>
        /// Конструктор, принимающий хранилища в качестве параметров
        /// </summary>
        public Cache(IStorage<Division> divisionStorage, IStorage<Employee> employeeStorage)
        {
            DivisionStorage = divisionStorage;
            EmployeeStorage = employeeStorage;
        }
    }
}