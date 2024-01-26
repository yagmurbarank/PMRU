using MediatR;
using PMRU.Application.DTOs;
using PMRU.Application.Interfaces.RedisCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Doctors.Queries.GetDoctorsByLocation
{
    public class GetDoctorsByLocationQueryRequest : IRequest<IList<GetDoctorsByLocationQueryResponseDto>>, ICacheableQuery
    {
        public int LocationID { get; internal set; }
        public GetDoctorsByLocationQueryRequest(int locationId)
        {
            this.LocationID = locationId;
        }

        public string CacheKey => $"GetDoctorsByLocation_{LocationID}";

        public double CacheTime => 1;
    }

}
