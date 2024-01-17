using AutoMapper;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.MappingProfiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<GetEmployeesQueryResponseDto, EmployeeVM>().ReverseMap();
            CreateMap<GetEmployeeByRegistrationNumberQueryResponseDto, EmployeeVM>().ReverseMap();
            CreateMap<DepartmentDto, DepartmentVM>().ReverseMap();
            CreateMap<LocationDto, LocationVM>().ReverseMap();
            CreateMap<PositionDto, PositionVM>().ReverseMap();
            CreateMap<CreateDoctorCommandRequest, CreateDoctorVM>().ReverseMap();
        }
    }
}
