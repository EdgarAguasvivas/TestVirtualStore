using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVirtualStore.DataAccess;
using TestVirtualStore.DataAccess.ViewModels;
using TestVirtualStore.Services;

namespace MardomTestVirtualStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpPost]
        public ActionResult PostLogin(LoginViewModel login)
        {
            var resultLogin = _accountService.Login(login);
            if (resultLogin != null)
            {
                User user = new User()
                {
                    ID = resultLogin.ID,
                    User_Name = resultLogin.User_Name,
                    Rol = resultLogin.Rol
                };
                return Ok(user);
            }
            return Ok("User or password are incorrect");
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult PostRegistration(RegistrationViewModel registration)
        {
            try
            {
                _accountService.Registration(registration);
            }
            catch (Exception e)
            {
                return BadRequest();
                throw;
            }
            
            return Ok();
        }
    }
}
