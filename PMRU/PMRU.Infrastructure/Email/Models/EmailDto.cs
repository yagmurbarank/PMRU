using PMRU.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Infrastructure.Email.Models
{
    public class EmailDto
    {
        public string Subject { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public EmployeeDto Employee { get; set; }

    }
}
