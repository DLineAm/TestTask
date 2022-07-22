
using System.Collections.Generic;
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
        private readonly HttpClient _http;

        public AppData(HttpClient http)
        {
            _http = http;
        }

        /// <summary>
        /// Выбранный сотрудник, используется на странице добавления/изменения сотрудника
        /// </summary>
        public Employee CurrentEmployee { get; set; }

        /// <summary>
        /// Выбранное подразделение, используется на странице со списком сотрудников
        /// </summary>
        public Division CurrentDivision { get; set; }

        /// <summary>
        /// Выбранное родительское подразделение, исползуется на странице добавления/изменения подразделения
        /// </summary>
        public Division CurrentDivisionFromList { get; set; }

        /// <summary>
        /// Список подразделений
        /// </summary>
        private IEnumerable<Division> _divisions;

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

        /// <summary>
        /// Инициализация базовых свойств
        /// </summary>
        /// <returns></returns>
        public async Task InitializeBaseProperties()
        {
            _divisions = await GetDivisionsAsync(true);
        }
    }
}