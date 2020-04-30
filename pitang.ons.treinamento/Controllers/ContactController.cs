using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pitang.ons.treinamento.entities;
using pitang.ons.treinamento.services;

namespace pitang.ons.treinamento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpGet("")]
        public IEnumerable<Contact> Get([FromServices] IContactService service)
        {
            return service.FindAll();
        }

        [HttpPost("{ownerId:int}/{userId:int}/{nick}")]
        public IActionResult Post([FromServices] IContactService contactService, [FromServices] IUserService userService, [FromRoute] int ownerId, [FromRoute] int userId, [FromRoute] string nick)
        {

            var owner = userService.FindBy(user => user.Id == ownerId);
            var user = userService.FindBy(user => user.Id == userId);
            
            if(owner.Count != 1)
                return NotFound("owner id not found: "+ownerId);

            if (user.Count != 1)
                return NotFound("user id not found: "+userId);

            Contact c = new Contact()
            {
                Nick = nick,
                Owner = owner[0],
                OwnerId = ownerId,
                ContactUser = user[0],
                ContactUserId = userId
            };
            contactService.Add(c);
            return Ok(c);
            
        }
    }
}