using JWT_Authentica.Interfaces;
using JWT_Authentica.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Authentica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public string Login([FromBody] LoginRequest obj)
        {
            var token = _authService.Login(obj);
            return token;
        }
        [HttpPost("assignRole")]
        public bool AssignRoleToUser([FromBody] AddUserRole userRole)
        {
            var assignrole = _authService.AssignRoleToUser(userRole);
            return assignrole;
        }
        [HttpPost("addUser")]
        public User Adduser([FromBody] User user)
        {
            var addedUser = _authService.AddUser(user);
            return addedUser;
        }
        [HttpPost("addRole")]
        public Role AddRole(int id, [FromBody] Role role)
        {
            var addrole = _authService.AddRole(role);
            return addrole;
        }
    }
}
