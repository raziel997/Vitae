using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vitae.Helpers.Crypto;
using Vitae.Models;
using Vitae.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vitae.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
    private vitaeContext _dBContext;

        public UserController(vitaeContext dBContext)
        {
            _dBContext = dBContext;
        }

        // GET: api/<UserController>
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            return Ok($"Estamos Listos {name}");
        }

        // POST api/<UserController>
        [HttpPost("login")]
        public IActionResult Auth([FromBody] AuthViewModel value)
        {

            var user = _dBContext.Users.Where(w => w.Username == value.UserName
            && w.Password == Encrypt.GetSHA256(value.Password));
            return Ok(user);
        }
    }
}