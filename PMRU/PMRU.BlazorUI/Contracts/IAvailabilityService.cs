using PMRU.BlazorUI.Models;
using PMRU.Domain.Entities;

namespace PMRU.BlazorUI.Contracts
{
    public interface IAvailabilityService
    {
        Task<List<Availability>> GetAvailabilities();
        Task<AvailabilityVM> GetAvailabilitiesByDotorId(string doctorId);
    }
}
