namespace TestTask.Server.Storage
{
    /// <summary>
    /// Класс, хранящий сервисы по работе с хранилищем
    /// </summary>
    public class DataServiceCollection
    {
        /// <summary>
        /// Конструктор, принимающий сервисы по работе с хранилищем в качестве параметров
        /// </summary>
        public DataServiceCollection(IDivisionStorageService divisions, IEmployeeStorageService employees)
        {
            Divisions = divisions;
            Employees = employees;
        }

        /// <summary>
        /// Заполнение хранилища данными
        /// </summary>
        public void FillCache()
        {
            Divisions.FillCache();
            Employees.FillCache();
        }

        /// <summary>
        /// Сервис по работе с данными подразделений
        /// </summary>
        public IDivisionStorageService Divisions { get; }

        /// <summary>
        /// Сервис по работе с данными сотрудников
        /// </summary>
        public IEmployeeStorageService Employees { get; }
    }
}