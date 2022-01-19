using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Form
    {
        public string Id { get; set; }
        public string FormName { get; set; }
        public string SerialNumber { get; set; }
        public string UserEducation { get; set; }
        public string Experience { get; set; }
        public string EventType { get; set; }
        public string Status { get; set; }
        public int IdUser { get; set; }

        public Form() { }

        public Form(string fnam, string uEduc, string exp, string eTyp, int idUs)
        {
            FormName = fnam;
            UserEducation = uEduc;
            Experience = exp;
            EventType = eTyp;
            IdUser = idUs;
        }
    }
}
