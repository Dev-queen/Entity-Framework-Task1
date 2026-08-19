using DotNet_Template1.Models;
using DotNet_Template1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_Template1.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UserController: ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(Users user)
        {
            return Created($"/api/user/{user.Id}", await _userService.CreateUser(user));
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _userService.GetAll());
        }
    }
}
