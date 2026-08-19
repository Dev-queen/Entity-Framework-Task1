using DotNet_Template1.Models;

namespace DotNet_Template1.Repistories.Interfaces
{
    public interface ITasksRepository
    {
        public Task<Tasks> CreateTask(Tasks newTask);
        public Task<Tasks> GetTaskById(int id);
    }
}
