using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormCardController : ControllerBase
    {
        private readonly IFormCardRepository formRepository;
        public FormCardController(IFormCardRepository formRepository)
        {
            this.formRepository = formRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetFormsCard()
        {
            return Ok(await formRepository.GetFormsCard());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FormCard>> GetFormCard(string id)
        {
            var result = await formRepository.GetFormCard(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<FormCard>> AddFormCard(FormCard form)
        {
            if (form == null)
            {
                return BadRequest();
            }

            var result = await formRepository.AddFormCard(form);
            return CreatedAtAction(nameof(GetFormCard), new { id = result.Id }, result);
        }

        [HttpPut]
        [Route("Approved")]
        public async Task<ActionResult<FormCard>> UpdateFormCardApproved(FormCard form)
        {
            return await formRepository.UpdateFormCardApp(form);
        }

        [HttpPut]
        [Route("Denied")]
        public async Task<ActionResult<FormCard>> UpdateFormCardDenied(FormCard form)
        {
            return await formRepository.UpdateFormCardDenied(form);
        }

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<FormCard>> DeleteForm(string id)
        //{
        //    var result = await formRepository.GetFormCard(id);

        //    if (result == null)
        //    {
        //        return NotFound($"Form with id = {id} not found");
        //    }

        //    return await formRepository.DeleteFormCard(id);
        //}
    }
}
