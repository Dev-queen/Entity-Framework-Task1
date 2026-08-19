using DotNet_Template1.Models;
using DotNet_Template1.Repistories.Interfaces;
using DotNet_Template1.Services.Interfaces;

namespace DotNet_Template1.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepistory _userRepistory;

        public UserService(IUserRepistory userRepistory)
        {
            _userRepistory = userRepistory;
        }

        public async Task<Users> CreateUser(Users user)
        {
            return await _userRepistory.CreateUser(user);
        }

        public async Task<List<Users>> GetAll()
        {
            return await _userRepistory.GetAll();
        }
    }
}
