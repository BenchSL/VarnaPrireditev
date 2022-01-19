using BlazorApp1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface ISurveyReprository
    {
        Task<IEnumerable<Survey>> GetSurveys();
        Task<Survey> GetSurvey(string id);
        Task<Survey> AddSurvey(Survey f1);
    }
}
