using CodePersuit.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodePersuit.Core.Controllers
{
    [Route("api/[controller]")]
    [ProducesResponseType(200, Type = typeof(User))]
    public class UserController : ControllerBase
    {
        [HttpGet("{userName}")]
        public ActionResult Get(string userName)
        {
            if (userName == "myUser")
                return Ok(new Models.User() { Name = "myUser" });
            else
                return NotFound();
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new User[]
            {
                new User {Name = "User1"},
                new User {Name = "User2"}
            };
        }


    }
}
