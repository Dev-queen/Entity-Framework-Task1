using DotNet_Template1.Data;
using DotNet_Template1.Models;
using DotNet_Template1.Repistories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Template1.Repistories
{
    public class UserRepistory : IUserRepistory
    {
        private readonly ApplicationDbContext _dbcontext;

        public UserRepistory(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Users> CreateUser(Users user)
        {
            _dbcontext.Users.Add(user);
            await _dbcontext.SaveChangesAsync();

            return user;
        }

        public async Task<List<Users>> GetAll()
        {
            return await _dbcontext.Users.ToListAsync();
        }
    }
}
