using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class FormCard
    {
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string IdForm { get; set; }
        [Required]
        public string Address { get; set; }
        public string SerialNumber { get; set; }
        public string Status { get; set; }

        public FormCard() { }
        public FormCard(string title, string idForm, string addr)
        {
            this.Title = title;
            this.IdForm = idForm;
            this.Address = addr;
        }
    }
}
