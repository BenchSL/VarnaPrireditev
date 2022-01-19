
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public enum Role { User, Admin, Organ }
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Inbox { get; set; }
    }
}
