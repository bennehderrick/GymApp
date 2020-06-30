using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gym_Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gym_Admin.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       static List<User> _users = new List<User>()
        {
            new User(){ UserId = 0, FirstName ="derrick", LastName="benneh", PhoneNumber=0247891306},
            new User(){ UserId = 1, FirstName ="desmond", LastName="benneh", PhoneNumber=0247649766},
            new User(){ UserId = 2, FirstName ="joyce", LastName="benneh", PhoneNumber=0247676766}
        };

       public IActionResult Get()
        {
            return Ok(_users);
        }

        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
              _users.Add(user);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public void Put( int id, [FromBody] User user)
        {
            _users[id] = user;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _users.RemoveAt(id);
        }
    }
}