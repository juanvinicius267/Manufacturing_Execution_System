using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Scania.Br.KD.LoginApi.Dao;
using Scania.Br.KD.LoginApi.Models;


namespace Scania.Br.KD.LoginApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserDao _context;

        public UsersController(UserDao context)
        {
            this._context = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Authenticate([FromBody]User userParam)
        {
            if (ModelState.IsValid)
            {
                User user = _context.GetAll(userParam);
                if (User != null)
                
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes("mesproductionkd$");
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Role)
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(30),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    user.Token = tokenHandler.WriteToken(token);

                    return Ok(user.Token);
                }
                return Unauthorized(); //401
            }
            return BadRequest(); //400
        }
        

           
        }

       
    }
