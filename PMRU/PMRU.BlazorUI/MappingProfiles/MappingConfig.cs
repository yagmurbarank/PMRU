using AutoMapper;
using PMRU.BlazorUI.Models;
using PMRU.BlazorUI.Models.Appointment;
using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Models.Doctor;
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
            CreateMap<EmployeeDto, EmployeeVM>().ReverseMap();
            CreateMap<AvailabilityDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();

            CreateMap<GetAppointmentsQueryResponseDto, AppointmentVM>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate.Date))
                .ReverseMap();
            CreateMap<GetAppointmentsByDateQueryResponseDto, AppointmentVM>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate.Date))
                .ReverseMap();
            CreateMap<GetAppointmentsByDoctorIdQueryResponseDto, AppointmentVM>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate.Date))
                .ReverseMap();
            CreateMap<GetAppointmentByEmployeeIdQueryResponseDto, AppointmentVM>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => src.AppointmentDate.Date))
                .ReverseMap();
            CreateMap<CreateAppointmentVM, CreateAppointmentCommandRequest>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => new DateTimeOffset(new DateTime(src.AppointmentDate.Year, src.AppointmentDate.Month, src.AppointmentDate.Day), TimeSpan.Zero)))
                .ForMember(dest => dest.AppointmentStartHour, opt => opt.MapFrom(src => src.AppointmentStartHour.ToTimeSpan()))
                .ForMember(dest => dest.AppointmentEndHour, opt => opt.MapFrom(src => src.AppointmentEndHour.ToTimeSpan()))
                .ReverseMap();
            CreateMap<UpdateAppointmentVM, UpdateAppointmentCommandRequest>()
                .ForMember(dest => dest.AppointmentDate, opt => opt.MapFrom(src => new DateTimeOffset(new DateTime(src.AppointmentDate.Year, src.AppointmentDate.Month, src.AppointmentDate.Day), TimeSpan.Zero)))
                .ForMember(dest => dest.AppointmentStartHour, opt => opt.MapFrom(src => src.AppointmentStartHour.ToTimeSpan()))
                .ForMember(dest => dest.AppointmentEndHour, opt => opt.MapFrom(src => src.AppointmentEndHour.ToTimeSpan()))
                .ReverseMap();
            CreateMap<DeleteAppointmentVM, DeleteAppointmentCommandRequest>().ReverseMap();

            CreateMap<GetDoctorByIdQueryResponseDto, DoctorVM>().ReverseMap();
            CreateMap<GetDoctorsQueryResponseDto, DoctorVM>().ReverseMap();
            CreateMap<CreateDoctorCommandRequest, CreateDoctorVM>().ReverseMap();
            CreateMap<UpdateDoctorCommandRequest, UpdateDoctorVM>().ReverseMap();
            CreateMap<DeleteDoctorCommandRequest, DeleteDoctorVM>().ReverseMap();
            CreateMap<GetDoctorsByLocationQueryResponseDto, DoctorVM>().ReverseMap();

            CreateMap<GetAvailabilitiesByDoctorIdQueryResponseDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();
            CreateMap<GetAvailabilityByIdQueryResponseDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();
            CreateMap<GetAvailabilitiesQueryResponseDto, AvailabilityVM>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.Date))
                .ReverseMap();
            CreateMap<CreateAvailabilityVM, CreateAvailabilityCommandRequest>()
               .ForMember(dest => dest.Date, opt => opt.MapFrom(src => new DateTimeOffset(new DateTime(src.Date.Year, src.Date.Month, src.Date.Day), TimeSpan.Zero)))
               .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime.ToTimeSpan()))
               .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.ToTimeSpan()))
               .ReverseMap();
            CreateMap<UpdateAvailabilityVM, UpdateAvailabilityCommandRequest>()
               .ForMember(dest => dest.Date, opt => opt.MapFrom(src => new DateTimeOffset(new DateTime(src.Date.Year, src.Date.Month, src.Date.Day), TimeSpan.Zero)))
               .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime.ToTimeSpan()))
               .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime.ToTimeSpan()))
               .ReverseMap();
            CreateMap<DeleteAvailabilityVM, DeleteAvailabilityCommandRequest>().ReverseMap();
            

            CreateMap<DateOnly, DateTime>().ConvertUsing(source => new DateTime(source.Year, source.Month, source.Day));
            CreateMap<DateTime, DateOnly>().ConvertUsing(dt => new DateOnly(dt.Year, dt.Month, dt.Day));
            CreateMap<DateTime?, DateOnly>().ConvertUsing(dt => dt.HasValue ? new DateOnly(dt.Value.Year, dt.Value.Month, dt.Value.Day) : default(DateOnly));
            CreateMap<TimeSpan, TimeOnly>().ConvertUsing(ts => new TimeOnly(ts.Hours, ts.Minutes, ts.Seconds));
            CreateMap<TimeSpan?, TimeOnly>().ConvertUsing(ts => ts.HasValue ? new TimeOnly(ts.Value.Hours, ts.Value.Minutes, ts.Value.Seconds) : default(TimeOnly));

        }
    }
}
