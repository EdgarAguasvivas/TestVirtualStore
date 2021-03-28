using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVirtualStore.DataAccess;
using TestVirtualStore.Services;

namespace MardomTestVirtualStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public List<User> GetUser()
        {
            return userService.GetUsers().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return userService.GetUser(id);
        }

        [HttpPost]
        public ActionResult<Product> PostUser(User user)
        {
            userService.InsertUser(user);
            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            userService.UpdateUser(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUser(int id)
        {
            var user = userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }

            userService.DeleteUser(id);

            return user;
        }

    }
}
