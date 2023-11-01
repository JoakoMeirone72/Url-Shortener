using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Url_Shortener.Entities;
using Url_Shortener.Models;
using Url_Shortener.Services.Interfaces;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userRepository)
        {
            _userService = userRepository;
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDto dto)
        {
            try
            {
                _userService.Create(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            return Created("Created", dto);
        }
    }
}

