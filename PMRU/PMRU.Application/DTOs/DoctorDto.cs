using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.DTOs
{
    public class DoctorDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
