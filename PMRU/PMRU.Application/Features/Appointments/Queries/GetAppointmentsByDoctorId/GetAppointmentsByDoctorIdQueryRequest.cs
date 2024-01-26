using MediatR;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Appointments.Queries.GetAppointmentsByDoctorId
{
    public class GetAppointmentsByDoctorIdQueryRequest : IRequest<IList<GetAppointmentsByDoctorIdQueryResponseDto>>, ICacheableQuery
    {
        public GetAppointmentsByDoctorIdQueryRequest(int doctorId)
        {
            DoctorId = doctorId;
        }

        public int DoctorId { get; set; }

        public string CacheKey => $"GetAppointmentsByDoctorId_{DoctorId}";

        public double CacheTime => 5;
    }
}
