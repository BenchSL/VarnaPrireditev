using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Survey
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }
        public string NameSurvey { get; set; } 
        public string Rating { get; set; } //User rating
        public string Preview { get; set; } //User preview
        public DateTime DateSub { get; set; } //Date of submission
    }
}
