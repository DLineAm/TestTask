using Blazored.SessionStorage;

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

        public Employee CurrentEmployee { get; set; }

        public Division CurrentDivision { get; set; }

        public Division CurrentDivisionFromList { get; set; }
        public IEnumerable<Division> Divisions { get; set; }
        public IEnumerable<Gender> Genders { get; private set; }

        public async Task RefreshBaseProperties()
        {
            Divisions = await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }

        public async Task InitializeBaseProperties()
        {
            Genders = await _http.GetFromJsonAsync<IEnumerable<Gender>>("genders");
            Divisions = await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }
    }
}