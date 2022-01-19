using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Inbox
    {
        [Key]
        public int Id { get; set; }
        public string message { get; set; }
        public string SerijskaSt { get; set; }
    }
}
