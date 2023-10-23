using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ENCHERE.model;
using System.Threading.Tasks;

namespace ENCHERE.Controllers
{
    [ApiController]
    [Route("api")]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == request.Username && u.Password == request.Password);

            if (user != null)
            {
                
                return Ok(new { Message = "Authentication successful" });
            }
            else
            {
               
                return Unauthorized(new { Message = "Authentication failed" });
            }
        }

    }
}
