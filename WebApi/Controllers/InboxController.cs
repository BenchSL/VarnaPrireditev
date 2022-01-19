using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Models;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InboxController : ControllerBase
    {
        private readonly IinboxRepository inboxRepository;
        public InboxController(IinboxRepository inboxRepository)
        {
            this.inboxRepository = inboxRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetInbox()
        {
            return Ok(await inboxRepository.GetInboxs());
        }

        [HttpPost]
        public async Task<ActionResult<Inbox>> AddInbox(Inbox Inbox)
        {
            if (Inbox == null)
            {
                return BadRequest();
            }

            var result = await inboxRepository.AddInbox(Inbox);
            return CreatedAtAction(nameof(GetInbox), new { id = result.Id }, result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Inbox>> GetInbox(int Id)
        {
            var result = await inboxRepository.GetInbox(Id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}
