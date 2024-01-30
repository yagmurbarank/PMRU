using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using PMRU.Infrastructure.Email.EmailServices;
using PMRU.Infrastructure.Email.Models;

namespace PMRU.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        
        public IActionResult SendEmail( EmailDto request)
        {
            _emailService.SendEmailAsync(request);
            return Ok();
        }
    }
}
