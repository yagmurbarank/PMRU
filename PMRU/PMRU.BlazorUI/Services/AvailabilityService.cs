using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class AvailabilityService : BaseHttpService, IAvailabilityService
    {
        public AvailabilityService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {

        }
    }
}
