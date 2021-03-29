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
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public List<User> GetUser()
        {
            return _userService.GetUsers().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return _userService.GetUser(id);
        }

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            _userService.InsertUser(user);
            return CreatedAtAction("GetUser", new { id = user.ID }, user);
        }

        [HttpPut("{id}")]
        public IActionResult PutUser(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _userService.UpdateUser(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUser(int id)
        {
            var user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(id);

            return user;
        }

    }
}
