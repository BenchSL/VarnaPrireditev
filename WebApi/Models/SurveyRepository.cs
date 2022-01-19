using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Database;

namespace WebApi.Models
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly FormContext surveyDbContext;
        public SurveyRepository(FormContext surveyDbContext)
        {
            this.surveyDbContext = surveyDbContext;
        }

        public async Task<Survey> AddSurvey(Survey survey)
        {
            var result = await surveyDbContext.Survey.AddAsync(survey);
            await surveyDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Survey> DeleteSurvey(string Id)
        {
            var result = await surveyDbContext.Survey.FirstOrDefaultAsync();
            surveyDbContext.Survey.Remove(result);
            await surveyDbContext.SaveChangesAsync(true);

            return result;
        }

        public async Task<Survey> GetSurvey(string Id)
        {
            return await surveyDbContext.Survey.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Survey>> GetSurveys()
        {
            return await surveyDbContext.Survey.ToListAsync();
        }
    }
}
