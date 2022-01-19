using BlazorApp1.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class SurveyService : ISurveyReprository
    {
        private readonly HttpClient httpClient;
        public SurveyService()
        {
            this.httpClient = new HttpClient();
        }
        public async Task<Survey> AddSurvey(Survey f1)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:44377/api/survey", f1);
            return await response.Content.ReadFromJsonAsync<Survey>();
        }

        public async Task<Survey> GetSurvey(string id)
        {
            return await httpClient.GetFromJsonAsync<Survey>($"https://localhost:44377/api/survey/{id}");
        }

        public async Task<IEnumerable<Survey>> GetSurveys()
        {
            return await httpClient.GetFromJsonAsync<List<Survey>>("https://localhost:44377/api/survey");
        }
    }
}
