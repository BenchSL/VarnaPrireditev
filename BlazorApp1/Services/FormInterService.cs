using BlazorApp1.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class FormInterService : IFormService
    {
        private readonly HttpClient httpClient;

        public FormInterService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Form> AddForm(Form f1)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:44377/api/form", f1);
            return await response.Content.ReadFromJsonAsync<Form>();
        }

        public async Task DeleteForm(string id)
        {
            await httpClient.DeleteAsync("https://localhost:44377/api/form/{id}");
        }

        public async Task<Form> GetForm(string id)
        {
            return await httpClient.GetFromJsonAsync<Form>($"https://localhost:44377/api/form/{id}");
        }

        public async Task<IEnumerable<Form>> GetForms()
        {
            return await httpClient.GetFromJsonAsync<List<Form>>("https://localhost:44377/api/form");
        }

        public async Task<Form> UpdateFormApproved(Form form)
        {
            var response = await httpClient.PutAsJsonAsync<Form>("https://localhost:44377/api/form/Approved", form);
            return await response.Content.ReadFromJsonAsync<Form>();
        }

        public async Task<Form> UpdateFormDenied(Form form)
        {
            var response = await httpClient.PutAsJsonAsync<Form>("https://localhost:44377/api/form/Denied", form);
            return await response.Content.ReadFromJsonAsync<Form>();
        }

    }
}
