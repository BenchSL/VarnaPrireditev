using BlazorApp1.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class FormCardService : IFormCardService
    {
        private readonly HttpClient httpClient;

        public FormCardService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<FormCard> AddFormCard(FormCard f1)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:44377/api/FormCard", f1);
            return await response.Content.ReadFromJsonAsync<FormCard>();
        }
        public async Task<FormCard> GetFormCard(string id)
        {
            return await httpClient.GetFromJsonAsync<FormCard>($"https://localhost:44377/api/FormCard/{id}");
        }

        public async Task<IEnumerable<FormCard>> GetFormsCard()
        {
            return await httpClient.GetFromJsonAsync<List<FormCard>>("https://localhost:44377/api/FormCard");
        }

        public async Task<FormCard> UpdateFormCardApproved(FormCard form)
        {
            var response = await httpClient.PutAsJsonAsync<FormCard>("https://localhost:44377/api/FormCard/Approved", form);
            return await response.Content.ReadFromJsonAsync<FormCard>();
        }

        public async Task<FormCard> UpdateFormCardDenied(FormCard form)
        {
            var response = await httpClient.PutAsJsonAsync<FormCard>("https://localhost:44377/api/FormCard/Denied", form);
            return await response.Content.ReadFromJsonAsync<FormCard>();
        }
    }
}
