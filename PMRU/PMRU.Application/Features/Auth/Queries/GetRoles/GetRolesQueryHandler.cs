using MediatR;
using Microsoft.AspNetCore.Identity;
using PMRU.Application.Features.Availabilities.Queries.GetAvailabilities;
using PMRU.Application.Interfaces.AutoMapper;
using PMRU.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMRU.Application.Features.Auth.Queries.GetRoles
{
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQueryRequest, IList<GetRolesQueryResponseDto>>
    {
        private readonly RoleManager<Role> roleManager;
        private readonly IMapper mapper;

        public GetRolesQueryHandler(RoleManager<Role> roleManager, IMapper mapper)
        {
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        public async Task<IList<GetRolesQueryResponseDto>> Handle(GetRolesQueryRequest request, CancellationToken cancellationToken)
        {
            var roles = roleManager.Roles.ToList();
            var map = mapper.Map<GetRolesQueryResponseDto, Role>(roles);
            return map;
        }
    }
}
