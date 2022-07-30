using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using TestTask.Shared;

namespace TestTask.Client.Services
{
    /// <summary>
    /// Класс, хранящий в себе данные, используемые в коде страниц
    /// </summary>
    public class AppData
    {
        private IEnumerable<Division> _divisions;
        private readonly HttpClient _http;
        private Employee _selectedEmployee;
        private List<Employee> _employees;
        private Division _selectedDivision;

        public AppData(HttpClient http)
        {
            _http = http;
        }

        /// <summary>
        /// Выбранный сотрудник, используется на странице добавления/изменения сотрудника
        /// </summary>
        public Employee SelectedEmployee
        {
            get => new Employee(_selectedEmployee);
            set => _selectedEmployee = value;
        }

        /// <summary>
        /// Список сотрудников
        /// </summary>
        public List<Employee> Employees
        {
            get => _employees ??= GetEmployees().ToList();
            set => _employees = value;
        }

        /// <summary>
        /// Выбранное подразделение, используется на странице со списком сотрудников
        /// </summary>
        public Division SelectedDivision
        {
            get => new Division(_selectedDivision);
            set => _selectedDivision = value;
        }

        /// <summary>
        /// Выбранное родительское подразделение, исползуется на странице добавления/изменения подразделения
        /// </summary>
        public Division SelectedDivisionFromList { get; set; }


        private async Task<IEnumerable<Division>> GetDivisions()
        {
            return await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }

        /// <summary>
        /// Получение списка подразделений
        /// </summary>
        public async Task<IEnumerable<Division>> GetDivisionsAsync(bool isForceReload = false)
        {
            return _divisions is null || isForceReload
                ? _divisions = await GetDivisions()
                : _divisions;
        }

        private IEnumerable<Employee> GetEmployees()
        {
            var resultList = new List<Employee>();
            foreach (var division in _divisions)
            {
                var employees = division.Employees;
                resultList.AddRange(employees);
            }

            return resultList;
        }

        /// <summary>
        /// Инициализация базовых свойств
        /// </summary>
        /// <returns></returns>
        public async Task InitializeBaseProperties()
        {
            _divisions = await GetDivisionsAsync(true);
            Employees = GetEmployees().ToList();
        }
    }
}