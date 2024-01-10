using MediatR;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMRU.Domain.Common;

namespace PMRU.Application.Features.Doctors.Command.DeleteDoctor
{
    public class DeleteDoctorCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}





