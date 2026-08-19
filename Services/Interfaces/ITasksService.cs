using DotNet_Template1.Models;

namespace DotNet_Template1.Services.Interfaces
{
    public interface ITasksService
    {
        public Task<Tasks> CreateTask(Tasks newTask);
        public Task<Tasks> GetTaskById(int id);
    }
}
