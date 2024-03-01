using users_api.Interfaces;
using users_api.Models;

namespace users_api.Services
{
    public class AuthService : IAuthService
    {
        public async Task<int> CreateAuthRecord(CreateUserInput userInput)
        {
            var createdId = 1;

            return createdId;
        }

        public async Task<AuthToken> Login(LoginInput loginInput)
        {
            var token = new AuthToken()
            {
                Token = "success"
            };

            return token;
        }

        public async Task<bool> Logout(AuthToken token)
        {
            return true;
        }
    }
}
