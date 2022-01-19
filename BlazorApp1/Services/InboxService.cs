using System.Collections.Generic;
using BlazorApp1.Models;
using BlazorApp1.Database;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class InboxService : IinboxService
    {
        private readonly HttpClient httpClient;

        public InboxService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Inbox> AddInbox(Inbox f1)
        {
            var response = await httpClient.PostAsJsonAsync("https://localhost:44377/api/Inbox", f1);
            return await response.Content.ReadFromJsonAsync<Inbox>();
        }

        public async Task<Inbox> GetInbox(int id)
        {
            return await httpClient.GetFromJsonAsync<Inbox>($"https://localhost:44377/api/Inbox/{id}");
        }

        public async Task<IEnumerable<Inbox>> GetInboxs()
        {
            return await httpClient.GetFromJsonAsync<List<Inbox>>("https://localhost:44377/api/Inbox");
        }
    }
}
