using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface IinboxRepository
    {
        Task<IEnumerable<Inbox>> GetInboxs();
        Task<Inbox> AddInbox(Inbox form);
        Task<Inbox> GetInbox(int Id);
    }
}
