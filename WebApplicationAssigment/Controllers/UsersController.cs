using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using AdultDataList = WebApplicationAssigment.Data.IUserService;

namespace WebApplicationAssigment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private AdultDataList usersService;

        public UsersController(AdultDataList usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<User>>> getUsers()
        {
            try
            {
                IList<User> users = usersService.GetUsers();
                return Ok(users);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> addUser([FromBody] User user)
        {
            try
            {
                User added = usersService.AddUser(user);
                return Created($"/{added.Username}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }


    }
}

