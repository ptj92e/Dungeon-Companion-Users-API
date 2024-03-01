using users_api.Interfaces;
using users_api.Models;

namespace users_api.Services
{
    public class UserService : IUserService
    {
        public async Task<User> GetUser(int id)
        {
            return new User()
            {
                Id = 1,
                FirstName = "Phillip",
                LastName = "Jones",
                Email = "ptj92e@gmail.com",
                Active = true
            };
        }
        
        public async Task<int> CreateNewUser(CreateUserInput input, int authId)
        {
            return 1;
        }

        public async Task<User> UpdateUserInfo(User user)
        {
            user.FirstName = "Amanda";

            return user;
        }

        public async Task<bool> DeleteUser(int id)
        {
            return true;
        }
    }
}
