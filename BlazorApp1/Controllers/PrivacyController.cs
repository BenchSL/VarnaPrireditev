using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlazorApp1.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PrivacyController : Controller
    {
        [HttpGet("PrivacyPolicy")]
        public async Task<ActionResult> PrivacyPolicy()
        {
            Response.Cookies.Append("PrivacyPolicy", $"{Guid.NewGuid()}");
            return Redirect("/");
        }
    }
}
