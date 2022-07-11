using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TestTask.Shared;

namespace TestTask.Client.Services
{
    public class AppData
    {
        private readonly HttpClient _client;

        public AppData(HttpClient client)
        {
            _client = client;
        }

        public Employee CurrentEmployee { get; set; }
        public Division CurrentDivision { get; set; }
        public Division CurrentDivisionFromEmployee { get; set; }
        public IEnumerable<Division> Divisions { get; set; }
        public IEnumerable<Gender> Genders { get; private set; }

        public async Task InitializeBaseProperties()
        {
            Genders = await _client.GetFromJsonAsync<IEnumerable<Gender>>("genders");
        }
    }
}