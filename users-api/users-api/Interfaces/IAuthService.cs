using users_api.Models;

namespace users_api.Interfaces
{
    public interface IAuthService
    {
        Task<int> CreateAuthRecord(CreateUserInput userInput);
        Task<AuthToken> Login(LoginInput loginInput);
        Task<bool> Logout(AuthToken token);
    }
}
