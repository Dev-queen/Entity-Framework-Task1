using DotNet_Template1.Data;
using DotNet_Template1.Models;
using DotNet_Template1.Repistories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Template1.Repistories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public TasksRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Tasks> CreateTask(Tasks newTask)
        {
            _dbcontext.Tasks.Add(newTask);
            await _dbcontext.SaveChangesAsync();

            return newTask;
        }

        public async Task<Tasks> GetTaskById(int id)
        {
           var query = _dbcontext.Tasks.AsQueryable();

            query = query.Include(t => t.User).Where(t => t.Id == id);

            var task = await query.SingleAsync();


            return task;
        }
    }
}
