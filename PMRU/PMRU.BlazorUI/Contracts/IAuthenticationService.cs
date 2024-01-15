namespace PMRU.BlazorUI.Contracts
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string email, string password);
        Task<bool> RegisterAsync(string fullName, string email, string password, string confirmPassword);
        Task Logout();
    }
}
