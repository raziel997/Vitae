using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vitae.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vitae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<UserController>
        [HttpPost("login")]
        public IActionResult Auth([FromBody] AuthViewModel value)
        {
            return Ok("Correcto");
        }
    }
}
