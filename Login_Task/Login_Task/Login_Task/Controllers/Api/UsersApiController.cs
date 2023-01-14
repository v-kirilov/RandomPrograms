using Login_Task.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Login_Task.Controllers.Api
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private IConfiguration configuration;
        public UsersController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpPost("")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);

            if (user!=null)
            {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User not found!");
        }

        [HttpGet("Admins")]
        [Authorize]
        public IActionResult AdminsEndpoint()
        {
            var curreUser = GetCurrentUser();
            return this.StatusCode(StatusCodes.Status200OK, $"Hi, {curreUser.GivenName}, you are {curreUser.Role}");

        }


        private string Generate(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Username),
                new Claim(ClaimTypes.Email,user.EmailAddress),
                new Claim(ClaimTypes.GivenName,user.GivenName),
                new Claim(ClaimTypes.Surname,user.Surname),
                new Claim(ClaimTypes.Role,user.Role)
            };

            var token = new JwtSecurityToken(configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(UserLogin userLogin)
        {
            var currnetUser = UserConstants.Users.FirstOrDefault(x => x.Username.ToLower() == userLogin.Username.ToLower() && x.Password == userLogin.Password);
            if (currnetUser!=null)
            {
                return currnetUser;
            }
            return null;
        }

        [HttpGet("Public")]
        public IActionResult Public()
        {
            return this.StatusCode(StatusCodes.Status200OK, "Hi, this is the public part.");
        }

        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity!=null)
            {
                var userClaims = identity.Claims;
                return new UserModel
                {
                    Username = userClaims.FirstOrDefault(x=>x.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaims.FirstOrDefault(x=>x.Type == ClaimTypes.Email)?.Value,
                    GivenName = userClaims.FirstOrDefault(x=>x.Type == ClaimTypes.GivenName)?.Value,
                    Surname = userClaims.FirstOrDefault(x=>x.Type == ClaimTypes.Surname)?.Value,
                    Role = userClaims.FirstOrDefault(x=>x.Type == ClaimTypes.Role)?.Value,
                };
            }

            return null;
        }
    }
}
