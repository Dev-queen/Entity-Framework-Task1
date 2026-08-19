using DotNet_Template1.Models;

namespace DotNet_Template1.Services.Interfaces
{
    public interface IUserService
    {
        public Task<Users> CreateUser(Users user);
        public Task<List<Users>> GetAll();

    }
}
