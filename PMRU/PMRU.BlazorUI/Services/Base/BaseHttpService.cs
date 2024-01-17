using Blazored.LocalStorage;
using System.Net.Http.Headers;
using PMRU.BlazorUI.Contracts;

namespace PMRU.BlazorUI.Services.Base
{
    public class BaseHttpService
    {
        protected IClient _client;
        protected Blazored.LocalStorage.ILocalStorageService _localStorage;

        public BaseHttpService(IClient client, Blazored.LocalStorage.ILocalStorageService localStorage)
        {
            this._client = client;
            this._localStorage = localStorage;
        }

        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException exception)
        {
            if (exception.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Invalid data was submitted", ValidationErrors = exception.Response, Success = false };
            }
            else if (exception.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The record was not found.", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "Something went wrong, please try again later.", Success = false };
            }
        }
        protected async Task AddBearerToken()
        {
            if (await _localStorage.ContainKeyAsync("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", await _localStorage.GetItemAsync<string>("token"));
        }
    }
}

