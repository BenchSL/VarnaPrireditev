using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Database
{
    public class FormContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlazorApp1.Database.FormContext;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


    }
}
