using PMRU.Infrastructure.Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Infrastructure.Email.EmailServices
{
    public interface IEmailService
    {
        void SendEmailAsync(EmailDto request);
    }
  
}
