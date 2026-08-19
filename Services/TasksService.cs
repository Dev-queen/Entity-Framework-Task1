using DotNet_Template1.Models;
using DotNet_Template1.Repistories.Interfaces;
using DotNet_Template1.Services.Interfaces;

namespace DotNet_Template1.Services
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository _taskRepo;
        
        public TasksService(ITasksRepository taskRepo)
        {
            _taskRepo = taskRepo;
        }

        public async Task<Tasks> CreateTask(Tasks newTask)
        {
            return await _taskRepo.CreateTask(newTask);
        }

        public async Task<Tasks> GetTaskById(int id)
        {
            return await _taskRepo.GetTaskById(id);
        }
    }
}
