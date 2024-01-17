using PMRU.BlazorUI.Models.Availability;
using PMRU.BlazorUI.Services.Base;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAvailabilityService
    {
        Task<List<AvailabilityVM>> GetAvailabilities();
        Task<List<AvailabilityVM>> GetAvailabilitiesByDoctorId(int doctorId);

        Task<Response<Guid>> CreateAvailability(CreateAvailabilityVM vm);
        Task<Response<Guid>> CreateAvailabilities(List<CreateAvailabilityVM> vm);
        Task<Response<Guid>> DeleteAvailability(DeleteAvailabilityVM vm);
        Task<Response<Guid>> DeleteAvailabilities(List<int> ids);
        Task<Response<Guid>> UpdateAvailability(UpdateAvailabilityVM vm);

    }
}
