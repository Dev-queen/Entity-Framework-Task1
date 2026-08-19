using DotNet_Template1.Models;
using DotNet_Template1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_Template1.Controllers
{
    [ApiController]
    [Route("/api/task")]
    public class TasksController: ControllerBase
    {
        private readonly ITasksService _tasksService;

        public TasksController(ITasksService tasksService)
        {
            _tasksService = tasksService;   
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(Tasks newTask)
        {
            return Created($"/api/task/{newTask.Id}", await _tasksService.CreateTask(newTask));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetTaskById(int id)
        {
            var data = await _tasksService.GetTaskById(id);

            return Ok(new
            {
                TaskId = data.Id,
                Title = data.Title,
                Description = data.Description,
                UserId = data.UserId,
                Name = data.User.Name
            });
        }
    }
}
