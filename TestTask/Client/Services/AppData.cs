using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using TestTask.Shared;

namespace TestTask.Client.Services
{
    /// <summary>
    /// Класс, хранящий в себе данные, используемые в коде страниц
    /// </summary>
    public class AppData
    {
        private readonly HttpClient _http;
        private readonly ISessionStorageService _storageService;

        public AppData(ISessionStorageService storageService, HttpClient http)
        {
            _http = http;
            _storageService = storageService;
        }

        public Employee CurrentEmployee { get; set; }

        public Division CurrentDivision { get; set; }

        public Division CurrentDivisionFromList { get; set; }
        public IEnumerable<Division> Divisions { get; set; }
        public IEnumerable<Gender> Genders { get; private set; }

        public async Task InitializeBaseProperties()
        {
            Genders = await _http.GetFromJsonAsync<IEnumerable<Gender>>("genders");
            var divisionFromSession = await _storageService.GetItemAsync<IEnumerable<Division>>("divisions");
            Divisions = divisionFromSession ?? await _http.GetFromJsonAsync<IEnumerable<Division>>("divisions");
        }
    }
}