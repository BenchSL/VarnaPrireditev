using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface ISurveyRepository
    {
        Task<IEnumerable<Survey>> GetSurveys();
        Task<Survey> GetSurvey(string Id);
        Task<Survey> AddSurvey(Survey survey);
        Task<Survey> DeleteSurvey(string Id);
    }
}
