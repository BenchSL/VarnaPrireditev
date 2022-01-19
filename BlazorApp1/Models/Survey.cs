using System;

namespace BlazorApp1.Models
{
    public class Survey
    {
        public string Id { get; set; }
        public string NameSurvey { get; set; }
        public string Rating { get; set; } //User rating
        public string Preview { get; set; } //User preview
        public DateTime DateSub { get; set; } //Date of submission

        public Survey()
        {

        }

        public Survey(string id, string NameSur, string Rat, string Pre, DateTime date)
        {
            this.Id = id;
            this.NameSurvey = NameSur;
            this.Rating = Rat;
            this.Preview = Pre;
            this.DateSub = date;
        }
    }
}
