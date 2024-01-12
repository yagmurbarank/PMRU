using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorById
{
    public class GetDoctorByIdQueryRequest : IRequest<GetDoctorByIdQueryResponseDto>
    {
        public GetDoctorByIdQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
