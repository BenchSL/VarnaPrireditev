using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class FormCard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string IdForm { get; set; }
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
