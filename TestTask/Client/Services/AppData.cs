﻿
using System;
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
        private Employee _currentEmployee;
        private List<Employee> _employees;
        private Division _currentDivision;
        private Division _currentDivisionFromList;

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
            set => _currentEmployee = value;
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
            set => _currentDivision = value;
        }

        /// <summary>
        /// Выбранное родительское подразделение, исползуется на странице добавления/изменения подразделения
        /// </summary>
        public Division CurrentDivisionFromList
        {
            get => _currentDivisionFromList;
            set => _currentDivisionFromList = value;
        }

        /// <summary>
        /// Список подразделений
        /// </summary>
        private async Task<IEnumerable<Division>> GetDivisions()
        {
            return await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }

        public async Task<IEnumerable<Division>> GetDivisionsAsync(bool forceReload = false)
        {
            if (forceReload)
            {
                return _divisions = await GetDivisions();
            }
            return _divisions ??= await GetDivisions();
        }

        public Division GetMainDivision(Division childrenDivision, Division parentDivision)
        {
            var subDivisions = _divisions.Where(d => d.DivisionId == parentDivision.Id);
            foreach (var subDivision in subDivisions)
            {
                if (subDivision.Id == childrenDivision.Id)
                    return childrenDivision;
                var foundDivision = GetMainDivision(childrenDivision, subDivision);
                if (foundDivision != null)
                {
                    return foundDivision;
                }
            }

            return null;
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