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
            CreateMap<DoctorDto, DoctorVM>().ReverseMap();
            CreateMap<AvailabilityDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();

            CreateMap<GetDoctorByIdQueryResponseDto, DoctorVM>().ReverseMap();
            CreateMap<GetDoctorsQueryResponseDto, DoctorVM>().ReverseMap();
            CreateMap<CreateDoctorCommandRequest, CreateDoctorVM>().ReverseMap();
            CreateMap<GetDoctorsByLocationQueryResponseDto, DoctorVM>().ReverseMap();

            CreateMap<GetAvailabilitiesByDoctorIdQueryResponseDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();
            CreateMap<GetAvailabilitiesQueryResponseDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();

            CreateMap<DateTime, DateOnly>().ConvertUsing(dt => new DateOnly(dt.Year, dt.Month, dt.Day));
            CreateMap<DateTime?, DateOnly>().ConvertUsing(dt => dt.HasValue ? new DateOnly(dt.Value.Year, dt.Value.Month, dt.Value.Day) : default(DateOnly));
            CreateMap<TimeSpan, TimeOnly>().ConvertUsing(ts => new TimeOnly(ts.Hours, ts.Minutes, ts.Seconds));
            CreateMap<TimeSpan?, TimeOnly>().ConvertUsing(ts => ts.HasValue ? new TimeOnly(ts.Value.Hours, ts.Value.Minutes, ts.Value.Seconds) : default(TimeOnly));

        }
    }
}
