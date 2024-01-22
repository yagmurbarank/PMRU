using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PMRU.BlazorUI.Contracts;
using PMRU.BlazorUI.Providers;
using PMRU.BlazorUI.Services.Base;

namespace PMRU.BlazorUI.Services
{
    public class AuthenticationService : BaseHttpService, IAuthenticationService
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IClient client, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider) : base(client, localStorage)
        {
            this._authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(string email, string password)
        {
            try
            {
                LoginCommandRequest authenticationRequest = new LoginCommandRequest() { Email = email, Password = password };
                var authenticationResponse = await _client.LoginAsync(authenticationRequest);
                
                if (authenticationResponse.Token != string.Empty)
                {
                    await _localStorage.SetItemAsync("token", authenticationResponse.Token);

                    // Set claims in Blazor and login state
                    await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedIn();

                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task Logout()
        {
            // Remove claims in Blazor and invalidate login state
            await((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedOut();
        }

        public async Task<bool> RegisterAsync(string fullName, string email, string password, string confirmPassword, string registrationNumber, string role)
        {
            try
            {
                RegisterCommandRequest registrationRequest = new RegisterCommandRequest() { FullName = fullName, Email = email, Password = password, ConfirmPassword = confirmPassword, RegistrationNumber= registrationNumber, Role=role };
                await _client.RegisterAsync(registrationRequest);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
