using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;
        IUserManager userManager;

        public UsersController(ILogger<UsersController> logger,IUserManager userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(UserModel userModel)
        {
            var result =await userManager.AddUser(userModel);

            return result ? Ok() : BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await userManager.GetUsers();
            return Ok(users);
        }


    }
}
