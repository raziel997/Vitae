using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Vitae.Helpers.Crypto;
using Vitae.Helpers.Repository;
using Vitae.Models;
using Vitae.Models.Common;
=======
using System.Collections.Generic;
using System.Linq;
using Vitae.Helpers.Crypto;
using Vitae.Models;
>>>>>>> e4a3c1f3c5ee043c040d2a2de9a365eaff5effca
using Vitae.ViewModel;
using Vitae.ViewModel.Responses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vitae.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
<<<<<<< HEAD
        IRepository<User> _repository;
        vitaeContext _context;
        AppSettings _appSettings;

        public UserController(IRepository<User> repository, vitaeContext context, AppSettings appSettings)
        {
            _context = context;
            _repository = repository;
            _appSettings = appSettings;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
=======
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
>>>>>>> e4a3c1f3c5ee043c040d2a2de9a365eaff5effca
        }

        // POST api/<UserController>
        [HttpPost("login")]
        public IActionResult Auth([FromBody] AuthViewModel value)
        {
<<<<<<< HEAD
            UserResponse userResponse = new();

            string EncPwd = Encrypt.GetSHA256(value.Password);

            
            var user = _context.Users.Where(w => w.Username == value.UserName &&
                                            w.Password == EncPwd).FirstOrDefault();
            if (user == null) return null;
            userResponse.UserName = user.Username;
            userResponse.Token = GetToken(user);

            return Ok("Correcto");
=======

            var user = _dBContext.Users.Where(w => w.Username == value.UserName
            && w.Password == Encrypt.GetSHA256(value.Password));
            return Ok(user);
>>>>>>> e4a3c1f3c5ee043c040d2a2de9a365eaff5effca
        }

        private string GetToken(User usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var JWTKey = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier,usuario.Oid.ToString()),
                        new Claim(ClaimTypes.NameIdentifier,usuario.Username)
                    }),
                Expires = DateTime.UtcNow.AddDays(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(JWTKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}