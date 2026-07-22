using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.DTOs;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequestDto request)
        {
            if (request.Username != "admin" || request.Password != "admin123")
            {
                return Unauthorized("Invalid username or password.");
            }

            var token = _jwtService.GenerateToken(request.Username);

            return Ok(new LoginResponseDto
            {
                Token = token
            });
        }
    }
}