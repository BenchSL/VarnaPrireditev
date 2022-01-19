using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormRepository formRepository;
        public FormController(IFormRepository formRepository)
        {
            this.formRepository = formRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetForms()
        {
            return Ok(await formRepository.GetForms());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Form>> GetForm(string id)
        {
            var result = await formRepository.GetForm(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Form>> AddForm(Form form)
        {
            if (form == null)
            {
                return BadRequest();
            }

            var result = await formRepository.AddForm(form);
            return CreatedAtAction(nameof(GetForm), new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        [Route("RemoveForm")]
        public async Task<ActionResult<Form>> DeleteForm(string id)
        {
            var result = await formRepository.GetForm(id);

            if (result == null)
            {
                return NotFound($"Form with id = {id} not found");
            }

            return await formRepository.DeleteForm(id);
        }

        [HttpPut]
        [Route("Approved")]
        public async Task<ActionResult<Form>> UpdateFormApproved(Form form)
        {
            return await formRepository.UpdateFormApp(form);
        }

        [HttpPut]
        [Route("Denied")]
        public async Task<ActionResult<Form>> UpdateFormDenied(Form form)
        {
            return await formRepository.UpdateFormDenied(form);
        }
    }
}
