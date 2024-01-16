using Blazored.LocalStorage;

namespace PMRU.BlazorUI.Services.Base
{
    public class BaseHttpService
    {
        protected IClient _client;
        private ILocalStorageService localStorage;

        public BaseHttpService(IClient client)
        {
            _client = client;
        }

        public BaseHttpService(IClient client, ILocalStorageService localStorage) : this(client)
        {
            this.localStorage = localStorage;
        }

        protected Response<Guid> ConvertApiExceptions(ApiException exception)
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
    }
}
