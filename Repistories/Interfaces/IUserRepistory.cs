using DotNet_Template1.Models;

namespace DotNet_Template1.Repistories.Interfaces
{
    public interface IUserRepistory
    {
        public Task<Users> CreateUser(Users user);
        public Task<List<Users>> GetAll();
    }
}
