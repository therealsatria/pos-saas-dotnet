using Microsoft.AspNetCore.Mvc;
using Infrastructures.DTOs.User;
using Infrastructures.Entities;
using Infrastructures.Services;
using Infrastructures.ResponseBuilder;
using Infrastructures.Exceptions;
using System;
using System.Threading.Tasks;

namespace Infrastructures.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetAllAsync();
            return ResponseBuilder.ResponseBuilder.Success(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _userService.GetByIdAsync(id);
            return ResponseBuilder.ResponseBuilder.Success(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreateRequest request)
        {
            var user = await _userService.AddAsync(request);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, 
                ResponseBuilder.ResponseBuilder.Success(user, "User created successfully."));
        }
    }
}