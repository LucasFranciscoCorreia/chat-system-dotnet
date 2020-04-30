using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.services;

namespace pitang.ons.treinamento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("")]
        #nullable enable
        public IActionResult GetUsers([FromServices] IUserService userService, [FromQuery] int? id, [FromQuery] string? email)
        {
            var users = userService.FindAll();

            if(id != null)
                users = users.Where(user => user.Id == id);
            if (email != null)
                users = users.Where(user => user.Email == email);
            return Ok(users);
        }

        [HttpPost("")]
        public IActionResult AddUser([FromServices] IUserService userService, [FromBody] User newUser)
        {
            newUser = userService.Add(newUser);
            return Ok(newUser);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromServices] IUserService userService, [FromQuery] int id)
        {
            IList<User> user = userService.FindBy(user => user.Id == id);
            if (user.Count != 1)
                return NotFound(id);
            
            return Ok(id);

        }

        public async Task<IActionResult> AddUserAsync([FromServices] IUserService userService, [FromBody] User newUser)
        {
            newUser = await userService.AddAsync(newUser);
            return Ok(newUser);
        }

    }
}