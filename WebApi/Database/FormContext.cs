using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Database
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options)
        : base(options)
        {

        }

        public DbSet<Form> Forms { get; set; }
        public DbSet<FormCard> FormCard { get; set; }
        public DbSet<Inbox> Inbox { get; set; }
        public DbSet<Survey> Survey { get; set; }

    }
}
