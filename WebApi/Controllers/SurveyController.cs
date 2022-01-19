using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ISurveyRepository surveyRepository;
        public SurveyController(ISurveyRepository surveyRepository)
        {
            this.surveyRepository = surveyRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetSurveys()
        {
            return Ok(await surveyRepository.GetSurveys());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Survey>> GetSurvey(string id)
        {
            var result = await surveyRepository.GetSurvey(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Survey>> AddSurvey(Survey survey)
        {
            if (survey == null)
            {
                return BadRequest();
            }

            var result = await surveyRepository.AddSurvey(survey);
            return CreatedAtAction(nameof(GetSurvey), new { id = result.Id }, result);
        }
    }
}
