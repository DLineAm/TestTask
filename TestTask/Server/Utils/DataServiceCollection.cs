using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Класс, хранящий сервисы по работе с данными
    /// </summary>
    public class DataServiceCollection
    {
        /// <summary>
        /// Конструктор, принимающий сервисы по работе с данными в качестве параметров
        /// </summary>
        /// <param name="divisions"></param>
        public DataServiceCollection(IStorageService<Division> divisions)
        {
            Divisions = divisions;
        }

        /// <summary>
        /// Сервис по работе с данными подразделений
        /// </summary>
        public IStorageService<Division> Divisions { get; }

        /// <summary>
        /// Сервис по работе с данными сотрудников
        /// </summary>
        public IStorageService<Employee> Employees { get; }
    }
}