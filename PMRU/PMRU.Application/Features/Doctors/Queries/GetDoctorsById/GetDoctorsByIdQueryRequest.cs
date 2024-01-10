using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsById
{
    public class GetDoctorsByIdQueryRequest
    {
        public GetDoctorsByIdQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
