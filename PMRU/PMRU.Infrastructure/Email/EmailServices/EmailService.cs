using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using PMRU.Infrastructure.Email.Models;
using System.Threading.Tasks;

namespace PMRU.Infrastructure.Email.EmailServices
{

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config; 
        public EmailService(IConfiguration config)
        {
            _config = config;
        }

       

        public void SendEmailAsync(EmailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("ignatius.ondricka@ethereal.email"));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(TextFormat.Html) { Text= request.Body };
            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("EmailUserName").Value, _config.GetSection("EmailPassword").Value);
            smtp.Send(email);
            smtp.Disconnect(true);

           
        }
        }
    }
