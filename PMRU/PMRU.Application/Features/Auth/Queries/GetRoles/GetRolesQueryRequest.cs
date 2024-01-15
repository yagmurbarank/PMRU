using MediatR;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Auth.Queries.GetRoles
{
    public class GetRolesQueryRequest : IRequest<IList<GetRolesQueryResponseDto>>
    {
    }
}
