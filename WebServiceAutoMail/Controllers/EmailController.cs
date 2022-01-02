using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceAutoMail.Model;
using WebServiceAutoMail.Services;

namespace WebServiceAutoMail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IMailService _mailService;

        public EmailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await _mailService.SendMailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
