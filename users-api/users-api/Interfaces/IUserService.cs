using users_api.Models;

namespace users_api.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUser(int id);
        Task<int> CreateNewUser(CreateUserInput input, int authId);
        Task<User> UpdateUserInfo(User user);
        Task<bool> DeleteUser(int id);
    }
}
