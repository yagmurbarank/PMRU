using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorByRegistrationNumber
{
    public class GetDoctorByRegistrationNumberQueryRequest :IRequest<GetDoctorByRegistrationNumberQueryResponseDto>, ICacheableQuery
    {
        public GetDoctorByRegistrationNumberQueryRequest(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;
        }

        public string RegistrationNumber { get; set; }

        public string CacheKey => $"GetDoctorByRegNo_{RegistrationNumber}";

        public double CacheTime => 5;
    }
}
