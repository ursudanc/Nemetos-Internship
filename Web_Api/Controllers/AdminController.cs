using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Api.Data;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private  AdministratorDbContext db;
        public AdminController(AdministratorDbContext db)
        {
            this.db = db;
        }
        [HttpGet("Login")]
        public IActionResult Get()
        {
            try
            {
                var users = db.Admins.ToList();
                if (users.Count == 0)
                {
                    return StatusCode(404, "No user found");
                }
                return Ok(users);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error has occured");
            }

        }
    }
}
