using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Database;

namespace WebApi.Models
{
    public class InboxRepository : IinboxRepository
    {
        private readonly FormContext inboxDbContext;
        public InboxRepository(FormContext inboxDbContext)
        {
            this.inboxDbContext = inboxDbContext;
        }
        public async Task<Inbox> AddInbox(Inbox inbox)
        {
            var result = await inboxDbContext.Inbox.AddAsync(inbox);
            await inboxDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Inbox> GetInbox(int Id)
        {
            return await inboxDbContext.Inbox.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Inbox>> GetInboxs()
        {
            return await inboxDbContext.Inbox.ToListAsync();
        }
    }
}
