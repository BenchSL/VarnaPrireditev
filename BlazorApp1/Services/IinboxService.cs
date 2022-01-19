using BlazorApp1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IinboxService
    {
        Task<IEnumerable<Inbox>> GetInboxs();
        Task<Inbox> GetInbox(int id);
        Task<Inbox> AddInbox(Inbox f1);
    }
}
