using Blazored.LocalStorage;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class DoctorService : BaseHttpService, IDoctorService
    {
        public DoctorService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {

        }
    }
}
