using System.Collections.Generic;
using System.Diagnostics;
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
        private Employee _currentEmployee;
        private List<Employee> _employees;
        private Division _currentDivision;
        private Division _currentDivisionFromList;
        private Division _divisionBackup;
        private Employee _employeeBackup;

        public AppData(HttpClient http)
        {
            _http = http;
        }

        /// <summary>
        /// Выбранный сотрудник, используется на странице добавления/изменения сотрудника
        /// </summary>
        public Employee CurrentEmployee
        {
            get => _currentEmployee;
            set
            {
                _currentEmployee = value;
                SetEmployeeBackup(_currentEmployee);
            }
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
        public Division CurrentDivision
        {
            get => _currentDivision;
            set
            {
                _currentDivision = value;
                SetDivisionBackup(_currentDivision);
            }
        }

        /// <summary>
        /// Выбранное родительское подразделение, исползуется на странице добавления/изменения подразделения
        /// </summary>
        public Division CurrentDivisionFromList
        {
            get => _currentDivisionFromList;
            set => _currentDivisionFromList = value;
        }

        
        private async Task<IEnumerable<Division>> GetDivisions()
        {
            return await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }

        /// <summary>
        /// Получение списка подразделений
        /// </summary>
        public async Task<IEnumerable<Division>> GetDivisionsAsync(bool forceReload = false)
        {
            if (forceReload)
            {
                return _divisions = await GetDivisions();
            }
            return _divisions ??= await GetDivisions();
        }

        private void SetDivisionBackup(Division division)
        {
            if (division == null)
            {
                _divisionBackup = null;
                return;
            }

            _divisionBackup = new Division
            {
                Title = division.Title,
                CreateDate = division.CreateDate,
                Description = division.Description,
                DivisionId = division.DivisionId,
                Employees = division.Employees,
                ParentDivision = division.ParentDivision,
                SubDivisions = division.SubDivisions,
                Id = division.Id
            };
        }

        private void SetEmployeeBackup(Employee employee)
        {
            if (employee == null)
            {
                _employeeBackup = null;
                return;
            }

            _employeeBackup = new Employee
            {
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                DateOfBirth = employee.DateOfBirth,
                Gender = employee.Gender,
                Division = employee.Division,
                DivisionId = employee.DivisionId,
                HasDriverLicense = employee.HasDriverLicense,
                Id = employee.Id
            };
        }

        public void RecoverDivision()
        {
            if (CurrentDivision == null)
            {
                return;
            }

            CurrentDivision.Title = _divisionBackup.Title;
            CurrentDivision.CreateDate = _divisionBackup.CreateDate;
            CurrentDivision.Description = _divisionBackup.Description;
            CurrentDivision.DivisionId = _divisionBackup.DivisionId;
            CurrentDivision.Employees = _divisionBackup.Employees;
            CurrentDivision.ParentDivision = _divisionBackup.ParentDivision;
            CurrentDivision.SubDivisions = _divisionBackup.SubDivisions;
        }

        public void RecoverEmployee()
        {
            if (CurrentEmployee == null)
            {
                return;
            }

            CurrentEmployee.FirstName = _employeeBackup.FirstName;
            CurrentEmployee.MiddleName = _employeeBackup.MiddleName;
            CurrentEmployee.LastName = _employeeBackup.LastName;
            CurrentEmployee.DateOfBirth = _employeeBackup.DateOfBirth;
            CurrentEmployee.Gender = _employeeBackup.Gender;
            CurrentEmployee.Division = _employeeBackup.Division;
            CurrentEmployee.DivisionId = _employeeBackup.DivisionId;
            CurrentEmployee.HasDriverLicense = _employeeBackup.HasDriverLicense;
            CurrentEmployee.Id = _employeeBackup.Id;
        }

        /// <summary>
        /// Определяет, является ли подразделение childrenDivision вложенным подразделением родительского подразделения parentDivision или его вложенных подразделений
        /// </summary>
        /// <param name="childrenDivision">Подразделение, которое нужно проверить</param>
        /// <param name="parentDivision">Предполагаемое родительское подразделение</param>
        /// <returns>True, если parentDivision является родительским подразделением childrenDivision. False, если нет</returns>
        public bool GetMainDivision(Division childrenDivision, Division parentDivision)
        {
            var subDivisions = parentDivision.SubDivisions.ToList();
            Debug.WriteLine(subDivisions.Count);
            foreach (var subDivision in subDivisions)
            {
                if (subDivision.Id == childrenDivision.Id)
                    return true;
                var foundDivision = GetMainDivision(childrenDivision, subDivision);
                if (foundDivision)
                {
                    return true;
                }
            }

            return false;
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